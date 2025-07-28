using FS.Data.Models.Measurements;
using FS.Reusable.Attributes.ErrorHandlingAttributes;

namespace FS.Data.Models.Meassurements
{
    public class Measurement(string shortName = "", string longName = "") : Model<int>, IMeasurement
    {
        private string _shortName = shortName;

        private string _longName = longName;

        [ShortTextLengthValidation(nameof(Measurement), nameof(ShortName))]
        public string ShortName { get => _shortName; set => _shortName = value; }
        
        [LongTextLengthValidation(nameof(Measurement), nameof(LongName))]
        public string LongName { get => _longName; set => _longName = value; }
    }
}
