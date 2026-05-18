using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    // Registra a fonte Montserrat (substitui OpenSans e Kalam como padrão)
                    fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular"); // Peso 400 (Regular)
                    fonts.AddFont("Montserrat-SemiBold.ttf", "MontserratSemiBold"); // Peso 600 (SemiBold)
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold"); // Peso 700 (Bold)
                    // Mantém OpenSans como fallback
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
