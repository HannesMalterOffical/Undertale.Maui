﻿namespace Undertale.Maui;

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
                fonts.AddFont("DTM-Mono.ttf", "UnderTaleMono");
                fonts.AddFont("DTM-Sans.ttf", "UnderTaleSans");
            });

		return builder.Build();
	}
}
