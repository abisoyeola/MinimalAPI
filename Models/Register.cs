using System.ComponentModel.DataAnnotations;

class Register{
    public int Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    [EmailAddress(ErrorMessage ="Invalid Email Address")]
    public string? Email { get; set; }
    [Required]
    public string? Username { get; set; }
    [Required]
    [MinLength(8,ErrorMessage ="Password Can't be less than 8")]
    public string? Password { get; set; }
    [Required]
    public string? Gender { get; set; }
    public DateTime DateRegistered { get; set; }
}