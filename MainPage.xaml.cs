namespace MauiCT_BUG1325_DrawingViewIsEnabled_Repro;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainPageViewModel();
    }
}