namespace MyDevTime.DataExtendable.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that support the addition, removal, and retrieval of data extensions.
    /// </summary>
    public interface IDataExtendable
    {
        /// <summary>
        /// Adds a new data extension to the object.
        /// </summary>
        /// <param name="dataExtension">The data extension to add.</param>
        public bool AddDataExtension(IDataExtension dataExtension);

        /// <summary>
        /// Removes an existing data extension from the object.
        /// </summary>
        /// <param name="extensionId">The data extension to remove.</param>
        public bool RemoveDataExtension(string extensionId);

        /// <summary>
        /// Retrieves a data extension by its unique identifier.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <returns>The <see cref="IDataExtension"/> that matches the given extension ID.</returns>
        public IDataExtension GetDataExtension(string extensionId);
    }
}