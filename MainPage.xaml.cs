using MauiAppVorbereitung.ViewModels;

namespace MauiAppVorbereitung;

public partial class MainPage : ContentPage
{
    

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    
}
