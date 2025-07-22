using FS.Reusable.Attributes;
using FS.Data.Base;
using FS.Data.Models.Measurements;

namespace FS.Data.Models.Meassurements
{
    public class Measurement(string shortName = "", string longName = "") : Model<int>, IMeasurement
    {
        private string _shortName = shortName;

        private string _longName = longName;

        [ShortTextValidation(nameof(Measurement), nameof(ShortName))]
        public string ShortName { get => _shortName; set => _shortName = value; }
        
        [LongTextValidation(nameof(Measurement), nameof(LongName))]
        public string LongName { get => _longName; set => _longName = value; }
    }
}
