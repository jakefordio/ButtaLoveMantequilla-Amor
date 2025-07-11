namespace ButtaLove.Services.Google
{
    public class ReCaptchaResponse
    {
        public bool Success { get; set; } = false;
        public bool IsVerified { get; set; } = false;
        public double Score { get; set; } = 0.0;
        public DateTime Challenge_ts { get; set; } = DateTime.Now;
        public string HostName { get; set; } = string.Empty;
        public List<string> ErrorCodes { get; set; } = new List<string> { string.Empty };
    }
}