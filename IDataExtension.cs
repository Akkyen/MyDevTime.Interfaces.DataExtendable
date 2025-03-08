namespace MyDevTime.Interfaces.DataExtendable
{
    /// <summary>
    /// Represents an individual data extension that can be added to an extendable object.
    /// </summary>
    public interface IDataExtension
    {
        #region Fields and Properties

        /// <summary>
        /// The id of the extension.
        /// </summary>
        string ExtensionId { get; set; }

        #endregion
    }
}