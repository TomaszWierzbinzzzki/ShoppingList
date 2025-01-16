using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ShoppingList.Models;

namespace ShoppingList.Services;

public class FileService
{
    private const string FilePath = "shoppinglist.json";

    public async Task SaveAsync(List<Category> categories)
    {
        var json = JsonSerializer.Serialize(categories);
        await File.WriteAllTextAsync(FilePath, json);
    }

    public async Task<List<Category>> LoadAsync()
    {
        if (!File.Exists(FilePath)) return new List<Category>();
        var json = await File.ReadAllTextAsync(FilePath);
        return JsonSerializer.Deserialize<List<Category>>(json);
    }
}
