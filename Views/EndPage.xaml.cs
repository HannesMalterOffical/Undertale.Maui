namespace Views;

public partial class EndPage : ContentPage
{
    public EndPage(Monsters monsters)
    {
        InitializeComponent();

        this.BindingContext = monsters;
        //this.BindingContext = bossMonsters;
        
    }
    //public void EndPageBoss(BossMonsters bossMonsters)
    //{
    //    InitializeComponent();

    //    this.BindingContext = bossMonsters;
    //    //this.BindingContext = bossMonsters;

    //}

    private void BackButton_Clicked(object sender, EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new SearchPage());
}