// ReSharper disable MissingXmlDoc
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
namespace FS.Data.Models.Measurements;

public class Measurement(string shortName = "", string longName = "") : Model<int>, IMeasurement
{
    [ShortTextLengthValidation(nameof(Measurement), nameof(ShortName))]
    public string ShortName { get; set; } = shortName;

    [LongTextLengthValidation(nameof(Measurement), nameof(LongName))]
    public string LongName { get; set; } = longName;
}