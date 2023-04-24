using Undertale.Maui.Models;
using static Java.Interop.JniEnvironment;

namespace Views;

public partial class EndPage : ContentPage
{
    public EndPage(Monsters monsters)
    {
        InitializeComponent();

        this.BindingContext = monsters;
    }
}