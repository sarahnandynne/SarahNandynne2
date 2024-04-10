using Microsoft.Maui.Controls;

namespace JogoSarah;

public partial class GameOverPage : ContentPage
{
    public GameOverPage()
    {
        InitializeComponent();
    }

    private void BotaoIniciarFoiClicado(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }
}