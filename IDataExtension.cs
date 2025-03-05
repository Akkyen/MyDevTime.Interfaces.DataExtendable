namespace MyDevTime.DataExtendable.Interfaces
{

    /// <summary>
    /// Represents an individual data extension that can be added to an extendable object.
    /// Inherits from <see cref="IDataExtendable"/>, making it capable of managing its own collection of data extensions.
    /// </summary>
    public interface IDataExtension<T> : IDataExtendable<T>
        where T : class, IDataExtension<T>
    {
        #region Fields and Properties
        
        /// <summary>
        /// The id of the extension which this DataExtension was made for.
        /// </summary>
        public string ExtensionId { get; }
        
        #endregion
    }
}