using Microsoft.Extensions.Logging;

namespace mobile_systems_project;

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

		//Seed data
		Seeder.Seeder.SeedData();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
