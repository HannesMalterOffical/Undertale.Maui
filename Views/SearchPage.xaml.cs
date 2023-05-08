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
        AllMonsterLst.ItemsSource = MonsterServices.GetAllMonsters();

        AllBossMonsterLst.ItemsSource = BossMonsterServices.GetAllBossMonsters();
    }

    async void Characters_SelectionChangedMonster(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new EndPage(e.CurrentSelection.First() as Monsters));
    }
    async void Characters_SelectionChangedBoss(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new EndPageBoss(e.CurrentSelection.First() as BossMonsters));
    }




    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }
}