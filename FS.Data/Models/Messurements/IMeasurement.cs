namespace FS.Data.Models.Measurements
{
    public interface IMeasurement : IModel<int>
    {
        public string ShortName { get; set; }

        public string LongName { get; set; }
    }
}
