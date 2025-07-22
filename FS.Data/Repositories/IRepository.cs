using FS.Data.Base;

namespace FS.Data.Repositories
{
    public interface IRepository<TModel, T> where TModel : Model<T>
    {
        IEnumerable<TModel> GetAll();

        Task<TModel> GetByIdAsync(int id);

        Task AddAsync(TModel model);
        
        TModel Update(TModel model);
        
        Task DeleteAsync(int id);
    }
}
