namespace MyDevTime.Interfaces.DataExtendable
{
    public interface IDataExtendable<T>
        where T : class, IDataExtension
    {
        #region DataExtendableFunctions
        
        bool AddDataExtension(T dataExtension);
        
        bool RemoveDataExtension(T dataExtension);
        
        #endregion
    }
}