using System.ComponentModel.DataAnnotations;

using static FS.Data.Constants;

namespace FS.Data.Attributes
{
    sealed public class LongTextValidationAttribute(string propertyName, string className, int minNameLength = MIN_LONG_TEXT_LENGTH, int maxNameLength = MAX_LONG_TEXT_LENGTH) : ValidationAttribute
    {

        private readonly int _minNameLength = minNameLength;

        private readonly int maxNameLength = maxNameLength;

        private readonly string _errorMessage = string.Format(ERROR_MESSAGE, className, propertyName, minNameLength, maxNameLength);

        public override bool IsValid(object? value)
        {
            string name = value is null ? "" : (string)value;
            return string.IsNullOrWhiteSpace(name) && IsValid(name);
        }

        internal bool IsValid(string name) => name.Length >= _minNameLength && name.Length <= maxNameLength;

        public override string FormatErrorMessage(string name) => _errorMessage;
    }
}
