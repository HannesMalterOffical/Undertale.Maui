

namespace Views;

public partial class EndPageBoss : ContentPage
{
    public EndPageBoss(BossMonsters bossMonsters)
    {
        InitializeComponent();

        this.BindingContext = bossMonsters;

    }

    private void BackButton_Clicked(object sender, EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new SearchPage());
}