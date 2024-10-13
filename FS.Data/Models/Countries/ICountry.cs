using FS.Data.Base;

namespace FS.Data.Models.Countries
{
    public interface ICountry : IModel<int>
    {
        string Name { get; set; }
    }
}
