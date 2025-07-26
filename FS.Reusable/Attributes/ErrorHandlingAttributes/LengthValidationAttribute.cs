using System.ComponentModel.DataAnnotations;

using static FS.Reusable.Constants;

[AttributeUsage(AttributeTargets.Property)]
public sealed class LengthValidationAttribute(string className, string propertyName, int minLength = MIN_SHORT_TEXT_LENGTH, int maxLength = MAX_SHORT_TEXT_LENGTH) : ValidationAttribute
    {
        private string _errorMessage = "";

        public override bool IsValid(object? value)
        {
            var text = value is null ? "" : (string)value;
            var length = text.Length;
            var isNotValid = length > maxLength || length < minLength;
            if (isNotValid)
            {
                _errorMessage = string.Format(LENGTH_ERROR_MESSAGE, propertyName, className, minLength, maxLength);
            }

            return !isNotValid;
        }

        public override string FormatErrorMessage(string name) => _errorMessage;
    }
