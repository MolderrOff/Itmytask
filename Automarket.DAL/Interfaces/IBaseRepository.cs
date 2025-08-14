using System.Collections.Generic;
using System.Threading.Tasks;

namespace Itmytask.DAL.Interfaces
{
    public interface IBaseRepository<T> 
    {                                     
        Task<bool> Create(T entity);
        Task<T> GetAsync(int id);  
        //IEnumerable<T> Select();
        Task<List<T>> Select(); 
        Task<List<T>> GetAsyncSelect();

        Task<bool> Delete(T entity);
        Task<bool> UpdateAsync(T entity);

    }
}
