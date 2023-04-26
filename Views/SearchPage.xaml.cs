using Undertale.Maui.Services;

namespace Views;

public partial class SearchPage : ContentPage
{
	
    public SearchPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        AllMonsterLst.ItemsSource = MonsterServices.GetAllMonsters();
    }

    async void Characters_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new EndPage(e.CurrentSelection.First() as Monsters));
    }


    async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }


    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }
}