using FS.Data.Repositories;

namespace FS.Data.UOWs
{
    public class UnitofWork(FSDatabaseContext context) : IUnitofWork, IDisposable
    {
        
        private readonly FSDatabaseContext _context = context;

        public FSDatabaseContext Context => _context;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void TransactionBegin()
        {
            throw new NotImplementedException();
        }

        public void TransactionCommit()
        {
            throw new NotImplementedException();
        }

        public void TransactionRollback()
        {
            throw new NotImplementedException();
        }

        public IRepository<TModel, T> GetRepository<TModel, T>() where TModel : Model<T> where T : class
        {
            return new Repository<TModel, T>(Context);
        }
    }
}
