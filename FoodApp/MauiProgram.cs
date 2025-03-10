using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace FoodApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()

                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SpaceGrotesk-Bold.otf", "SpaceB");
                    fonts.AddFont("SpaceGrotesk-Regular.otf", "SpaceR");
                    fonts.AddFont("SpaceGrotesk-Medium.otf", "SpaceM");
                    fonts.AddFont("SpaceMono-Regular.ttf", "SpaceMR");
                    fonts.AddFont("SpaceMono-Italic.otf", "SpaceMI");
                    fonts.AddFont("fontello-icons.ttf", "Icons");









                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
