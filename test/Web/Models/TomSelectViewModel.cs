using System.ComponentModel.DataAnnotations;

namespace RazorKit.Web.Test.Models;

public class TomSelectViewModel
{
    [Required(ErrorMessage = "Choose a country.")]
    public string? Country { get; set; } = "tr";
    public string[] Languages { get; set; } = ["cs", "js"];
    public string? Remote { get; set; } = "42";
    public AddressSelection Address { get; set; } = new();
}

public class AddressSelection
{
    public string? Country { get; set; } = "de";
}
