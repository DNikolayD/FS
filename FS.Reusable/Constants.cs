// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Constants type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FS.Reusable
{
    /// <summary>
    /// The constants.
    /// </summary>
    public abstract class Constants
    {
        /// <summary>
        /// The mi n_ shor t_ tex t_ length.
        /// </summary>
        public const int MIN_SHORT_TEXT_LENGTH = 5;

        /// <summary>
        /// </summary>
        public const int MAX_SHORT_TEXT_LENGTH = 50;

        public const int MIN_LONG_TEXT_LENGTH = 10;

        public const int MAX_LONG_TEXT_LENGTH = 100;

        public const float MIN_VALUE = 0.01f;

        public const float MAX_VALUE = 999999.99f;

        public const string LENGTH_ERROR_MESSAGE = "The length of the ${0} in the ${1} must be between ${2} and ${3} characters";

        public const string VALUE_ERROR_MESSAGE = "The value of the ${0} in the ${1} must be between ${2} and ${3}";
    }
}
