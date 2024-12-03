using ExpenserAPI.Model;
using System.Text.Json;

namespace ExpenserAPI.utility
{
    public class JsonReader:IFileReader
    {
        private string _filePath;
        public JsonReader(string _path) {
            _filePath = _path;
            if (!File.Exists(_path)) {
                var mockData = new List<Category> {
                    new Category{CategoryId=1,CategoryName="Bridal Expense", ParentCategoryId=null},
                    new Category{CategoryId=2,CategoryName="Marriage Expense", ParentCategoryId=null},
                    new Category{CategoryId=3,CategoryName="Bridal Clothing Expense", ParentCategoryId=1},
                };
                File.WriteAllText(_path, JsonSerializer.Serialize(mockData));
            }   
        }

        public List<Category> getCategories()
        {
            var jsonData = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Category>>(jsonData) ?? new List<Category>();
        }

        public Category getCategoryById(int id)
        {
            var categories = getCategories();
            return categories.FirstOrDefault(c => c.CategoryId == id);
        }

    }
}
