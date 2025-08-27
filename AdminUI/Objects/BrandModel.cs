namespace AdminUI.Objects
{
    public class BrandModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BrandModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public BrandModel()
        { }
        public BrandModel(BrandModel model)
        {
            Id = model.Id;
            Name = model.Name;
        }
    }
    public class BrandResponse
    {
        public string Message { get; set; }
        public BrandModel Data { get; set; }

    }
    public class ListBrandModel
    {
        public string Message { get; set; }
        public List<BrandModel> Data { get; set; }

    }
}

