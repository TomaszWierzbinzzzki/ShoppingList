using ShoppingList.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

public class DataService
{
    private string _filePath = Path.Combine(FileSystem.AppDataDirectory, "itemList.json");

    public async Task SaveDataAsync(ItemList itemList)
    {
        var jsonData = JsonConvert.SerializeObject(itemList);
        await File.WriteAllTextAsync(_filePath, jsonData);
    }
    public async Task<ItemList> LoadDataAsync()
    {
        if (File.Exists(_filePath))
        {
            var jsonData = await File.ReadAllTextAsync(_filePath);
            return JsonConvert.DeserializeObject<ItemList>(jsonData);
        }
        return new ItemList();
    }
}
