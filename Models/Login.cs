
using System.ComponentModel.DataAnnotations;

public class Login
{
    [EmailAddress(ErrorMessage ="Invalid email address")]
    public string? Email { get; set; }
    public string? Username { get; set; }
    [Required(AllowEmptyStrings = false,ErrorMessage ="Supply Password")]
    public string? Password { get; set; }
}