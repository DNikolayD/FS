using FS.Data.Base;

namespace FS.Data.Models.Messurements
{
    public class Messurement(string shortName = "", string longName = "") : Model<int>, IMessurement
    {
        private string _shortName = shortName;

        private string _longName = longName;

        public string ShortName { get => _shortName; set => _shortName = value; }
        
        public string LongName { get => _longName; set => _longName = value; }
    }
}
