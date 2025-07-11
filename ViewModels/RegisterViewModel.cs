using System.ComponentModel.DataAnnotations;

namespace ButtaLove.ViewModels;

public class RegisterViewModel
{
    #region Google

    public string GoogleReCaptchaResponseToken { get; set; }

    #endregion

    #region UserFields

    [Display(Name = "Email Street (Username)")]
    [EmailAddress]
    [StringLength(55, ErrorMessage = "Email Street should be at least 7 characters, 55 maximum", MinimumLength = 7)]
    public string Email { get; set; }
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(20, ErrorMessage = "First name should be at least 3 characters, 20 maximum", MinimumLength = 3)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(20, ErrorMessage = "First name should be at least 3 characters, 20 maximum", MinimumLength = 3)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Birthday is required")]
    [StringLength(12, ErrorMessage = "Birthday Month and Day should be at least 6 characters, 12 maximum",
        MinimumLength = 6)]
    [Display(Name = "Birth day and Month")]
    public string BirthDate { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(30, ErrorMessage = "Password should be at least 8 characters, 30 maximum", MinimumLength = 8)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Password Confirmation is required")]
    [Compare(nameof(Password), ErrorMessage = "Passwords don't match")]
    [StringLength(30, ErrorMessage = "First name should be at least 8 characters, 30 maximum", MinimumLength = 8)]
    public string PasswordConfirm { get; set; }

    #endregion
}