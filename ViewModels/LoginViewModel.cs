using System.ComponentModel.DataAnnotations;

namespace ButtaLove.ViewModels;

public class LoginViewModel
{
    #region Google
    [Required(ErrorMessage = "Google ReCaptcha Response Token is required")]
    public string GoogleReCaptchaResponseToken { get; set; }
    #endregion
    
    #region UserFields
    [Required(ErrorMessage = "UserName is required")]
    [EmailAddress(ErrorMessage = "Email is invalid")]
    [Display(Name = "UserName(Email Street)")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [Display(Name = "Remember Me?")]
    public bool RememberMe { get; set; } = false;

    #endregion
}