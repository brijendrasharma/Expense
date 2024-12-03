using System.Text.Json.Serialization;

namespace ExpenserAPI.Model
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [JsonPropertyName("parent_category_id")]
        public int? ParentCategoryId { get; set; }

    }
}
