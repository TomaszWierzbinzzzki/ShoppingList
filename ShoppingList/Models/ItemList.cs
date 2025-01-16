using System.Collections.ObjectModel;

namespace ShoppingList.Models
{
    public class ItemList
    {
        public ObservableCollection<Category> Categories { get; set; }

        public ItemList()
        {
            Categories = new ObservableCollection<Category>();
        }
    }
}

