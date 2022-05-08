using Microsoft.UI.Xaml.Controls;

using PenguinTranslator.ViewModels;

namespace PenguinTranslator.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = App.GetService<MainViewModel>();
            InitializeComponent();
        }
    }
}
