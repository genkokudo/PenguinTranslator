using Microsoft.UI.Xaml.Controls;

using PenguinTranslator.ViewModels;

namespace PenguinTranslator.Views
{
    public sealed partial class ContentGridPage : Page
    {
        public ContentGridViewModel ViewModel { get; }

        public ContentGridPage()
        {
            ViewModel = App.GetService<ContentGridViewModel>();
            InitializeComponent();
        }
    }
}
