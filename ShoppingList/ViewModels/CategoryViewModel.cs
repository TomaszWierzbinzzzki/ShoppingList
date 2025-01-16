using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ShoppingList.Models;

namespace ShoppingList.ViewModels;

public class CategoryViewModel : INotifyPropertyChanged
{
    public string Name { get; set; }
    public ObservableCollection<Product> Products { get; set; }
    public ICommand AddProductCommand { get; }

    private string _productName;
    public string ProductName
    {
        get => _productName;
        set
        {
            _productName = value;
            OnPropertyChanged();
        }
    }

    public CategoryViewModel(string name)
    {
        Name = name;
        Products = new ObservableCollection<Product>();
        AddProductCommand = new Command(AddProduct);
    }

    private void AddProduct()
    {
        if (!string.IsNullOrWhiteSpace(ProductName))
        {
            Products.Add(new Product(ProductName, "szt.", 1));
            ProductName = string.Empty;
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
