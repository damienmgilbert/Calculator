using Calculator.ViewModels;
using Calculator.Views;
using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Calculator
{
    public static class MauiProgram
    {

        #region Private methods
        private static MauiAppBuilder RegisterRoutes(this MauiAppBuilder builder)
        {
            builder.Services.AddTransientWithShellRoute<CalculatorPage, CalculatorViewModel>("Home");
            builder.Services.AddTransientWithShellRoute<UnitConverterPage, UnitConverterViewModel>("UnitConverter");
            return builder;
        }
        private static MauiAppBuilder RegisterView(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<SimpleCalculatorView>();
            builder.Services.AddTransient<ScientificCalculatorView>();
            return builder;
        }
        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<SimpleCalculatorViewModel>();
            builder.Services.AddTransient<ScienfiticCalculatorViewModel>();
            return builder;
        }
        #endregion

        #region Public methods
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                .RegisterViewModels()
                .RegisterView()
                .RegisterRoutes()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            Ioc.Default.ConfigureServices(builder.Services.BuildServiceProvider());
            return builder.Build();
        }
        #endregion

    }
}
