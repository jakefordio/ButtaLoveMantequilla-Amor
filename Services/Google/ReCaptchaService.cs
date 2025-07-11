using Newtonsoft.Json;

namespace ButtaLove.Services.Google
{
    public class ReCaptchaService
    {
        public async Task<ReCaptchaResponse> VerifyTokenAsync(string token)
        {
            ReCaptchaResponse googleResult = new();
            string url = $"https://www.google.com/recaptcha/api/siteverify?secret={GoogleKeys.GOOGLE_RECAPTCHA_SECRETKEY}&response={token}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(url).ConfigureAwait(false);
                //if the response code is bad, shit the bed
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    googleResult.Success = false;
                    googleResult.IsVerified = false;
                }
                else //if the response code is good, get the full response object
                {
                    string responseString = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    googleResult = JsonConvert.DeserializeObject<ReCaptchaResponse>(responseString);
                    googleResult.IsVerified = (googleResult.Success == true && googleResult.Score >= 0.5);
                }

                return googleResult;
            }
        }
    }
}