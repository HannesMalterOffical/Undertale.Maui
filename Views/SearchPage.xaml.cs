namespace Views;

public partial class SearchPage : ContentPage
{
	private const uint AnimationDuration = 800u;
	public SearchPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

        ViewMonsters.ItemsSource = Monsters.GetAllMonsters();
        ViewBossMonsters.ItemsSource = BossMonsters.GetAllBossMonsters();
    }

    async void Characters_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new EndPage(e.CurrentSelection.First() as Monsters));
    }


    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}