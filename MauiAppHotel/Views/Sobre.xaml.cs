using System;
namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private void Button_Voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
