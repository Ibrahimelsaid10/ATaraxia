
namespace ATaraxia.Core.Repositories;

public interface IBaseRepository <T> where T : class
{

    Task<T> GetByIdAsync(Guid id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);


    Task<T> CreateAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(Guid id);



}
