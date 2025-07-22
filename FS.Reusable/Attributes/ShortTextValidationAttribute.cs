using System.ComponentModel.DataAnnotations;

using static FS.Reusable.Constants;

namespace FS.Reusable.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="className"></param>
    /// <param name="propertyName"></param>
    /// <param name="minNameLength"></param>
    /// <param name="maxNameLength"></param>
    public sealed class ShortTextValidationAttribute(
        string className,
        string propertyName,
        int minNameLength = MIN_SHORT_TEXT_LENGTH,
        int maxNameLength = MAX_SHORT_TEXT_LENGTH) : ValidationAttribute
    {
        private readonly int _minNameLength = minNameLength;

        private readonly int _maxNameLength = maxNameLength;

        private readonly string _errorMessage = string.Format(ERROR_MESSAGE, args: [className, propertyName, minNameLength, maxNameLength]);

        public override bool IsValid(object? value)
        {
            var name = value is null ? "" : (string)value;
            return string.IsNullOrWhiteSpace(name) && this.IsValid(name);
        }

        private bool IsValid(string name) => name.Length >= this._minNameLength && name.Length <= _maxNameLength;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name) => _errorMessage;
    }
}
