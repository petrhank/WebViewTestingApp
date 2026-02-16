using Microsoft.Extensions.Logging;

namespace WebViewTestingApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

#if ANDROID
            // Povolí ladění WebView přes Chrome DevTools (pouze pro Debug buildy)
            Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
#endif

            return builder.Build();
        }
    }
}