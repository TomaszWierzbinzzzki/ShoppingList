using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ShoppingList.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        public ObservableCollection<Product> ShoppingList { get; set; }
        public ObservableCollection<Product> CartList { get; set; }
        public ObservableCollection<Category> ProductCategories { get; set; }

        public ICommand ToggleProductCommand { get; }

        public MainPageViewModel()
        {
            ShoppingList = new ObservableCollection<Product>();
            CartList = new ObservableCollection<Product>();
            ProductCategories = new ObservableCollection<Category>
            {
                new Category { Name = "Nabiał", Products = new ObservableCollection<Product> { new Product { Name = "Mleko", Unit = "szt.", IsPurchased = false } } },
                new Category { Name = "Warzywa", Products = new ObservableCollection<Product> { new Product { Name = "Marchew", Unit = "kg", IsPurchased = false } } }
            };

            ToggleProductCommand = new Command<Product>(OnProductToggled);
        }

        private void OnProductToggled(Product product)
        {
            if (product.IsPurchased)
            {
                ShoppingList.Remove(product);
                CartList.Add(product);
            }
            else
            {
                CartList.Remove(product);
                ShoppingList.Add(product);
            }
        }
    }

    public class Product : BindableObject
    {
        private bool _isPurchased;

        public string Name { get; set; }
        public string Unit { get; set; }

        public bool IsPurchased
        {
            get => _isPurchased;
            set
            {
                _isPurchased = value;
                OnPropertyChanged();
            }
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public ObservableCollection<Product> Products { get; set; }
    }
}
