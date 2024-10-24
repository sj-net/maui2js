using Maui2JS.Core;
using Maui2JS.Core.Abstractions;
using Microsoft.Extensions.Logging;

namespace Maui2JS.Demo
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<Maui2JS.Core.Preferences>();
#if ANDROID
            builder.Services.AddSingleton<ILocalNotificationService, Maui2JS.Core.Android.LocalNotificationService>();
#endif

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            Maui2JS.Core.Preferences.Init();
            var build = builder.Build();

            Ioc.Default.SetServiceProvider(build.Services);

            return build;
        }
    }
}
