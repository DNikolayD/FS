using FS.Data.Base;
using FS.Data.Models.Categories;
using FS.Data.Models.Measurements;

namespace FS.Data.Models.Products
{
    public interface IProduct : IModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int MeasureUnitId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public Category Category { get; set; }

        public IMeasurement MeasureUnit { get; set; }
    }
}
