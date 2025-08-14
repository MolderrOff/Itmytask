using Itmytask.Domain.Entity;
using System.Threading.Tasks;

namespace Itmytask.DAL.Interfaces
{
    public interface IWorkRepository : IBaseRepository<Work>  
        
         {
        Task<Work> GetByNameAsync(string name);  
       

    }
}
