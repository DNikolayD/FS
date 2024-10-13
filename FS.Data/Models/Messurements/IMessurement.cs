using FS.Data.Base;

namespace FS.Data.Models.Messurements
{
    public interface IMessurement : IModel<int>
    {
        public string ShortName { get; set; }

        public string LongName { get; set; }
    }
}
