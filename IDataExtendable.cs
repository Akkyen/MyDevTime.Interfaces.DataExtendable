using System.Collections.Generic;

namespace MyDevTime.Interfaces.DataExtendable
{
    /// <summary>
    /// Defines a contract for objects that support the addition, removal, and retrieval of data extensions.
    /// </summary>
    /// <typeparam name="T">The type of the extension. Needs to implement <see cref="IDataExtension"/></typeparam>
    public interface IDataExtendable<T>
        where T : class, IDataExtension
    {
        #region Fields and Properties

        /// <summary>
        /// Stores all extensions.
        /// </summary>
        ICollection<T> Extensions { get; set; }

        #endregion
        
        
        #region DataExtendableFunctions

        /// <summary>
        /// Adds a new data extension to the object implementing IDataExtendable.
        /// </summary>
        /// <param name="dataExtension">The data extension to add.</param>
        bool AddDataExtension(T dataExtension);

        /// <summary>
        /// Removes an existing data extension from the object implementing IDataExtendable.
        /// </summary>
        /// <param name="dataExtension">The data extension to remove.</param>
        bool RemoveDataExtension(T dataExtension);

        /// <summary>
        /// Retrieves a data extension by its unique identifier.
        /// </summary>
        /// <param name="extensionId">The id of the extension.</param>
        /// <param name="dataExtension">The requested extension or null</param>
        /// <returns>True if an extension was found otherwise false.</returns>
        bool GetDataExtension(string extensionId, out T dataExtension);
        
        #endregion
    }
}