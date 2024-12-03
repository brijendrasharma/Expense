using ExpenserAPI.Model;

namespace ExpenserAPI.utility
{
    public interface IFileReader
    {

        Category getCategoryById(int id);
        List<Category> getCategories();
    }
}
