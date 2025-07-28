namespace FS.Reusable
{
    /// <summary>
    /// This class contains constants used in the application. Currently, it only contains constants for error messages.
    /// </summary>
    public abstract class Constants
    {
        /// <summary>
        /// This constant is used to determine the minimum length of a short text field, such as a name.
        /// History of changes in values: 1 -> 5
        /// </summary>
        public const int MIN_SHORT_TEXT_LENGTH = 5;

        /// <summary>
        /// This constant is used to determine the maximum length of a short text field, such as a name.
        /// History of changes in values: 10 -> 50
        /// </summary>
        public const int MAX_SHORT_TEXT_LENGTH = 50;

        /// <summary>
        /// This constant is used to determine the minimum length of a long text field, such as a description.
        /// History of changes in values: 5 -> 10
        /// </summary>
        public const int MIN_LONG_TEXT_LENGTH = 10;

        /// <summary>
        /// This constant is used to determine the maximum length of a long text field, such as a description.
        /// History of changes in values: 50 -> 100
        /// </summary>
        public const int MAX_LONG_TEXT_LENGTH = 100;

        /// <summary>
        /// This constant is used to determine the minimum value of a value field, such as a price.
        /// History of changes in values: none.
        /// </summary>
        public const float MIN_VALUE = 0.01f;

        /// <summary>
        /// This constant is used to determine the maximum value of a value field, such as a price.
        /// History of changes in values: none.
        /// </summary>
        public const float MAX_VALUE = 999999.99f;

        /// <summary>
        /// This constant is used to format error messages for length validation of short and long text fields.
        /// {0} is replaced with the field name, {1} is replaced with the class name, {2} is replaced with the minimum length, {3} is replaced with the maximum length
        /// </summary>
        public const string LENGTH_ERROR_MESSAGE = "The length of the ${0} in the ${1} must be between ${2} and ${3} characters";

        /// <summary>
        /// This constant is used to format error messages for value validation of value fields.
        /// {0} is replaced with the field name, {1} is replaced with the class name, {2} is replaced with the minimum value, {3} is replaced with the maximum value
        /// </summary>
        public const string VALUE_ERROR_MESSAGE = "The value of the ${0} in the ${1} must be between ${2} and ${3}";
    }
}
