using ShoppingList.ViewModels;
namespace ShoppingList.Views;

public partial class CategoryPage : ContentPage
{
    public string CategoryName { get; set; }

    public CategoryPage(string categoryName)
    {
        InitializeComponent();
        CategoryName = categoryName;
        BindingContext = this;
    }
}
