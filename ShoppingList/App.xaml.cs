using Microsoft.Maui.Controls;
using ShoppingList.ViewModels;

namespace ShoppingList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
