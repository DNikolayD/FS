using Microsoft.EntityFrameworkCore;

namespace FS.Data.Repositories
{
    public class Repository<TModel, T>(FSDatabaseContext context) : IRepository<TModel, T> where TModel : Model<T> where T : class
    {
        private readonly DbSet<TModel> _dbSet = context.Set<TModel>();

        public async Task AddAsync(TModel model)
        {
            await _dbSet.AddAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            _dbSet.Remove(model);
        }

        public IEnumerable<TModel> GetAll()
        {
            return _dbSet;
        }

        public async Task<TModel> GetByIdAsync(int id)
        {
            return (await _dbSet.FindAsync(id))!;
        }

        public TModel Update(TModel model)
        {
            _dbSet.Update(model);
            return model;
        }
    }
}
