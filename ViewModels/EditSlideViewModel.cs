namespace ButtaLove.ViewModels;

public class UpdateSlideViewModel
{
    #region Google
    public string GoogleReCaptchaResponseToken { get; set; }
    #endregion
    
    #region Carousel Fields
    public string ImagePath { get; set; }
    public string CaptionHeading { get; set; }
    public string CaptionBody { get; set; }
    public bool IsActive { get; set; }
    #endregion
}