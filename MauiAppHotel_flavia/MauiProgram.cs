using Microsoft.Extensions.Logging;

namespace MauiAppHotel_flavia
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
                    fonts.AddFont("GreatVibes-Regular.ttf", "GreatVibes-Regular");
                    fonts.AddFont("HenryPenny-Regular.ttf", "HenryPenny-Regular");
                    fonts.AddFont("Lato-Black.ttf", "Lato-Black");
                    fonts.AddFont("Lato-Bold.ttf", "Lato-Bold");
                    fonts.AddFont("Lato-Italic.ttf", "Lato-Italic");
                    fonts.AddFont("Lato-Light.ttf", "Lato-Light");
                    fonts.AddFont("Lato-Regular.ttf", "Lato-Regular");
                    fonts.AddFont("Lato-Thin.ttf", "Lato-Thin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
