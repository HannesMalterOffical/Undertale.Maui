using Views;

namespace Undertale.Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new BeginningPage());
    }
}
