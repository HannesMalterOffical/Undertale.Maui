namespace Undertale.Maui;

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
                fonts.AddFont("MonsterFriendBack.otf", "UnterTaleBack");
                fonts.AddFont("MonsterFriendFore.otf", "UnterTaleFore");
            });

		return builder.Build();
	}
}
