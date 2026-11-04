using System.Diagnostics;
using System.Text;
using Microsoft.Playwright;
using Xunit;

namespace RazorKit.UiTests;

public sealed class BrowserFixture : IAsyncLifetime
{
    private Process? _server;
    private IPlaywright? _playwright;
    public IBrowser Browser { get; private set; } = null!;
    public string BaseUrl { get; private set; } = "";
    public string Root { get; private set; } = "";

    public async Task InitializeAsync()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory != null && !File.Exists(Path.Combine(directory.FullName, "RazorKit.sln"))) directory = directory.Parent;
        Root = directory?.FullName ?? throw new InvalidOperationException("Could not find RazorKit.sln.");
        BaseUrl = Environment.GetEnvironmentVariable("RAZORKIT_TEST_URL") ?? "";
        if (BaseUrl.Length == 0)
        {
#if DEBUG
            const string configuration = "Debug";
#else
            const string configuration = "Release";
#endif
            var webRoot = Path.Combine(Root, "test", "Web");
            var start = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = webRoot, UseShellExecute = false,
                RedirectStandardOutput = true, RedirectStandardError = true, CreateNoWindow = true
            };
            start.ArgumentList.Add(Path.Combine(webRoot, "bin", configuration, "net8.0", "RazorKit.Web.Test.dll"));
            start.ArgumentList.Add("--urls");
            start.ArgumentList.Add("http://127.0.0.1:0");
            start.Environment["ASPNETCORE_ENVIRONMENT"] = "Development";
            var ready = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
            var output = new StringBuilder();
            _server = new Process { StartInfo = start, EnableRaisingEvents = true };
            void Receive(object sender, DataReceivedEventArgs e)
            {
                if (e.Data == null) return;
                lock (output) output.AppendLine(e.Data);
                const string marker = "Now listening on: ";
                var index = e.Data.IndexOf(marker, StringComparison.Ordinal);
                if (index >= 0) ready.TrySetResult(e.Data[(index + marker.Length)..].Trim());
            }
            _server.OutputDataReceived += Receive;
            _server.ErrorDataReceived += Receive;
            _server.Exited += (_, _) => ready.TrySetException(new InvalidOperationException("Test server exited: " + output));
            _server.Start();
            _server.BeginOutputReadLine();
            _server.BeginErrorReadLine();
            try { BaseUrl = await ready.Task.WaitAsync(TimeSpan.FromSeconds(45)); }
            catch { await DisposeAsync(); throw; }
        }
        try
        {
            _playwright = await Playwright.CreateAsync();
            var engine = Environment.GetEnvironmentVariable("PLAYWRIGHT_BROWSER") ?? "chromium";
            var browserType = engine switch { "firefox" => _playwright.Firefox, "webkit" => _playwright.Webkit, _ => _playwright.Chromium };
            Browser = await browserType.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true, Channel = Environment.GetEnvironmentVariable("PLAYWRIGHT_CHANNEL")
            });
        }
        catch { await DisposeAsync(); throw; }
    }

    public async Task DisposeAsync()
    {
        if (Browser != null) await Browser.CloseAsync();
        _playwright?.Dispose();
        if (_server != null)
        {
            if (!_server.HasExited) { _server.Kill(entireProcessTree: true); await _server.WaitForExitAsync(); }
            _server.Dispose();
            _server = null;
        }
    }
}
