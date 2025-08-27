using Bogus.DataSets;
using DocumentFormat.OpenXml.Spreadsheet;

namespace AdminUI.Objects
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public CategoryModel()
        { }
        public CategoryModel(CategoryModel model)
        {
            Id = model.Id;
            Name = model.Name;
        }
    }
    public class CategoryResponse
    {
        public string Message { get; set; }
        public CategoryModel Data { get; set; }

    }
    public class ListCategoryModel
    {
        public string Message { get; set; }
        public List<CategoryModel> Data { get; set; }

    }
}
