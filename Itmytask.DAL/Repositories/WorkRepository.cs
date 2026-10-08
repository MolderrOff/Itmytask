using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itmytask.DAL.Interfaces;
using Itmytask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Itmytask.DAL.Repositories
{
    public class WorkRepository : IWorkRepository

    {
        private readonly ApplicationDbContext _db;
        public WorkRepository(ApplicationDbContext db)  
        {
            _db = db;
        }
        public async Task<bool> Create(Work entity)  
                                        
        {
            await _db.Work.AddAsync(entity);
            await _db.SaveChangesAsync();
            return true; 
        }
        public async Task<Work> GetAsync(int id)  
        {
            return await _db.Work.FirstOrDefaultAsync(x => x.Id == id);
;       }              
        public async Task<List<Work>> GetAsyncSelect()  
        {
            string query = "SELECT 'Id', 'NameTask', 'TaskNumber', 'Description', 'Customer', 'AdressTask', 'Price', 'TypeWork'";
            var works = await _db.Work.FromSqlRaw(query, "public.Work").ToListAsync();        
            return works; 

        }
       

        public async Task<List<Work>> Select()
        {

            List<Work> works = await _db.Work.ToListAsync(); 
            return works;             
        }

        public async Task<bool> DeleteAsync(Work entity)
        {
            _db.Work.Remove(entity);
            await _db.SaveChangesAsync(); 
            return true;
        }

        public async Task<Work> GetByNameAsync(string name) 
        {
            return await _db.Work.FirstOrDefaultAsync(x => x.NameTask == name);
        }

        async Task<bool> IBaseRepository<Work>.Delete(Work entity)
        {
            _db.Work.Remove(entity);
            await _db.SaveChangesAsync(); 
            return true;
        }
        public async Task<bool> UpdateAsync(Work entity)
        {
            _db.Work.Update(entity);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
