using System.ComponentModel.DataAnnotations;

using static FS.Reusable.Constants;

namespace FS.Reusable.Attributes.ErrorHandlingAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ValueValidationAttribute(string className, string propertyName, float minValue = MIN_VALUE, float maxValue = MAX_VALUE) : ValidationAttribute
    {
        private string _errorMessage = "";

        public override bool IsValid(object? propertyValue)
        {
            var number = propertyValue is null ? 0.00f : (float)propertyValue;
            var isNotValid = number > maxValue || number < minValue;
            if (isNotValid)
            {
                _errorMessage = string.Format(VALUE_ERROR_MESSAGE, propertyName, className, minValue, maxValue);
            }
            return !isNotValid;

        }

        public override string FormatErrorMessage(string name) => _errorMessage;
    }
}
