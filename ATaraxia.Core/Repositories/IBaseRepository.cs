using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATaraxia.Core.Repositories
{
    public interface IBaseRepository <T> where T : class
    {

        Task<T> GetByIdAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);


        Task<T> CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(Guid id);



    }
}
