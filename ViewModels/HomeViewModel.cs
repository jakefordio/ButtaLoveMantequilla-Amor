using ButtaLove.Models;

namespace ButtaLove.ViewModels;

public class HomeViewModel
{
   #region General
   public List<Slide> Slides { get; set; } = [];
   public List<Slide> Testimonials { get; set; } = [];
   public List<Slide> Seasonals { get; set; } = [];
   #endregion General
   
   #region Google
   public string? ReCaptchaSiteKey { get; set; }
   public string? ReCaptchaApiLink { get; set; }
   public string ReCaptchaResponseToken { get; set; }

   #endregion Google
}