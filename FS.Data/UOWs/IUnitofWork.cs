using FS.Data.Repositories;

namespace FS.Data.UOWs
{
    public interface IUnitofWork : IDisposable
    {
        void TransactionBegin();

        void TransactionCommit();
        
        void TransactionRollback();

        void Save();

       IRepository<TModel, T> GetRepository<TModel, T>() where TModel : Model<T> where T : class;
    }
}
