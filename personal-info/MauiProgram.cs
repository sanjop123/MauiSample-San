using Microsoft.Extensions.Logging;
using personal_info.Data;
using MediatR;
using Personal_Service;
using System.Reflection;

namespace personal_info
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

          //  builder.Services.AddMediatR(typeof(Personal_Service.SubmitPersonInforamtionHandler).Assembly) ;
            builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(typeof(SubmitPersonInforamtionHandler).GetTypeInfo().Assembly));

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();


            return builder.Build();
        }
    }
}