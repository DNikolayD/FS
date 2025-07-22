namespace FS.Reusable.Attributes
{
    using System.ComponentModel.DataAnnotations;

    using static FS.Reusable.Constants;

    /// <summary>
    /// The long text validation attribute.
    /// </summary>
    public class LongTextValidationAttribute : ValidationAttribute
    {

        private readonly int _minNameLength;

        private readonly int maxNameLength;

        private readonly string _errorMessage;

        public LongTextValidationAttribute(string propertyName, string className, int minNameLength = MIN_LONG_TEXT_LENGTH, int maxNameLength = MAX_LONG_TEXT_LENGTH)
        {
            this._minNameLength = minNameLength;
            this.maxNameLength = maxNameLength;
            this._errorMessage = string.Format(ERROR_MESSAGE, className, propertyName, minNameLength, maxNameLength);
        }

        public override bool IsValid(object? value)
        {
            var name = value is null ? string.Empty : (string)value;
            return string.IsNullOrWhiteSpace(name) && this.IsValid(name);
        }

        private bool IsValid(string name) => name.Length >= _minNameLength && name.Length <= maxNameLength;

        public override string FormatErrorMessage(string name) => _errorMessage;
    }
}
