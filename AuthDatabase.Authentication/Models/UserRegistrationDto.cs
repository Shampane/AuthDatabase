using System.ComponentModel.DataAnnotations;

namespace AuthDatabase.Authentication.Models;

public class UserRegistrationDto
{
    [Required(ErrorMessage = "UserName is Required")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Email is Required")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is Required")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare(
        "Password",
        ErrorMessage = "The password and confirmation password do not match"
    )]
    public string ConfirmPassword { get; set; }
}
