using System.ComponentModel.DataAnnotations;

using static FS.Data.Constants;

namespace FS.Data.Attributes
{
    sealed public class ValueValidationAttribute( string className, string propertyName, float minValue = MIN_VALUE, float maxValue = MAX_VALUE) : ValidationAttribute
    {
        private readonly float _minValue = minValue;

        private readonly float _maxValue = maxValue;

        private readonly string _errorMessage = string.Format(ERROR_MESSAGE, className, propertyName, minValue, maxValue);

        public override bool IsValid(object? value)
        {
            float val = value is null ? 0.0f : (float)value;
            return val >= _minValue && val <= _maxValue;
        }

        public override string FormatErrorMessage(string name) => _errorMessage;
    }
}
