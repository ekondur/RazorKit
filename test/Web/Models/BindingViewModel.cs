namespace RazorKit.Web.Test.Models;

public class BindingViewModel
{
    public int? Number { get; set; } = 2;
    public int[] Numbers { get; set; } = [1, 3];
    public ExampleChoice Choice { get; set; } = ExampleChoice.Second;
    public string? Unknown { get; set; } = "remote-value";
    public AddressSelection Shipping { get; set; } = new();
}

public enum ExampleChoice { First = 1, Second = 2 }
