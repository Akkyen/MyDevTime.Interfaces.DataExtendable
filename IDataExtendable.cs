using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MyDevTime.DataExtendable.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that support the addition, removal, and retrieval of data extensions.
    /// </summary>
    public interface IDataExtendable<T>
        where T : class, IDataExtension<T>
    {
        #region Fields and Properties

        /// <summary>
        /// Is used to store all Extensions identified by their ExtensionId.
        /// </summary>
        public ICollection<T> Extensions { get; }

        #endregion


        #region DataExtendableFunctions

        /// <summary>
        /// Adds a new data extension to the object.
        /// </summary>
        /// <param name="dataExtension">The data extension to add.</param>
        public bool AddDataExtension(T dataExtension);

        /// <summary>
        /// Removes an existing data extension from the object.
        /// </summary>
        /// <param name="extensionId">The data extension to remove.</param>
        public bool RemoveDataExtension(string extensionId);

        /// <summary>
        /// Retrieves a data extension by its unique identifier.
        /// </summary>
        /// <param name="extensionId">The id of the extension.</param>
        /// <param name="dataExtension">The requested extension or null</param>
        /// <returns>True if an extension was found otherwise false.</returns>
        public bool GetDataExtension(string extensionId, [NotNullWhen(true)] out T dataExtension);

        #endregion
    }
}