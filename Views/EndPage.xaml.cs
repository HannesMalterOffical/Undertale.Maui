

namespace Views;

public partial class EndPage : ContentPage
{
    public EndPage(Monsters monsters)
    {
        InitializeComponent();

        this.BindingContext = monsters;
    }

    private void BackButton_Clicked(object sender, EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new SearchPage());
}