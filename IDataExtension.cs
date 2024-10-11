namespace MyDevTime.DataExtendable.Interfaces
{
    /// <summary>
    /// Represents an individual data extension that can be added to an extendable object.
    /// Inherits from <see cref="IDataExtendable"/>, making it capable of managing its own set of data extensions.
    /// </summary>
    public interface IDataExtension : IDataExtendable
    {
        /// <summary>
        /// Retrieves the unique identifier for the data extension.
        /// </summary>
        /// <returns>A string representing the unique ID of this data extension.</returns>
        public string GetExtensionId();
    }
}