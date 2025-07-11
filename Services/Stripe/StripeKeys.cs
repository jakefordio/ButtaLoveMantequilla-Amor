namespace ButtaLove.Services.Stripe
{
    public static class StripeKeys
    {
        public static string? SecretKey { get; set; }
        public static string? PublishableKey { get; set; }
        public static string? SecretKeyTest { get; set; }
        public static string? PublishableKeyTest { get; set; }
        public static string? WebHookSecret { get; set; }
        public static bool? CalculateTax { get; set; }
    }
}