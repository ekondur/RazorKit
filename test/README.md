# RazorKit test application and tests

All interactive examples are in **one** ASP.NET Core web project:

```powershell
dotnet run --project test/Web --launch-profile http
```

Open http://localhost:5161. The home page links to DataTables, Chart.js (all ten existing examples), SweetAlert2 and Tom Select. Tom Select 2.6.2 assets are vendored with their license, so its UI tests do not depend on a CDN. The existing examples for other libraries retain their CDN assets.

## Unit tests

On Windows with the .NET 10 SDK, .NET 8 runtime and .NET Framework 4.8:

```powershell
dotnet test test/TomSelect.UnitTests -p:GeneratePackageOnBuild=false
dotnet test test/DataTables.UnitTests -p:GeneratePackageOnBuild=false
```

Both projects target net48, net8.0 and net10.0. On other platforms, select a supported framework with `-f net8.0` or `-f net10.0`.

## Browser tests

```powershell
dotnet build test/UiTests -p:GeneratePackageOnBuild=false
pwsh test/UiTests/bin/Debug/net8.0/playwright.ps1 install chromium firefox
dotnet test test/UiTests --no-build
```

No Node.js installation or separately started web server is needed. The fixture starts the shared web app on a dynamic loopback port and shuts it down afterward. Each test gets a fresh browser context.

To use an installed Chrome instead of downloading Chromium:

```powershell
$env:PLAYWRIGHT_CHANNEL = 'chrome'
dotnet test test/UiTests --no-build
```

For Firefox, remove `PLAYWRIGHT_CHANNEL` and set `PLAYWRIGHT_BROWSER=firefox`. `RAZORKIT_TEST_URL` optionally points to an already running instance. Browser traces are saved under `artifacts/playwright`; the examples screenshot is `artifacts/tom-select.png`. Open a trace with the generated `playwright.ps1 show-trace <path>` command.

The CI workflow runs unit tests on all three frameworks and browser tests in Chromium and Firefox. UI tests cover navigation, initialization, keyboard selection, scalar/collection/nested binding, ModelState and validation, tags, grouping, disabled controls, custom rendering and escaping, search, limits, remote GET/POST, errors, virtual scrolling, plugins and a mobile viewport.
