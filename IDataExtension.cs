namespace MyDevTime.Interfaces.DataExtendable
{
    /// <summary>
    /// Represents an individual data extension that can be added to an extendable object.
    /// Inherits from <see cref="IDataExtendable"/>, making it capable of managing its own collection of data extensions.
    /// </summary>
    public interface IDataExtension
    {
        #region Fields and Properties

        /// <summary>
        /// The id of the extension which this DataExtension was made for.
        /// </summary>
        string ExtensionId { get; set; }

        #endregion
    }
}