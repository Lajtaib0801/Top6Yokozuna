using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using System.Runtime.Intrinsics.Arm;

namespace Top6Yokozuna
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("RiiT_F.otf", "riit");
                    fonts.AddFont("ZinHenaKokuryu - RDF.ttf", "ZinHenaKokuryuRDF");
                    fonts.AddFont("impact.ttf", "Impact");
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