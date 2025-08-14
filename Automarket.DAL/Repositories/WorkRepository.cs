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
;        }

        public async Task<List<Work>> GetAsyncSelect()  
        {
            string query = "SELECT 'Id', 'NameTask', 'TaskNumber', 'Description', 'Customer', 'AdressTask', 'Price', 'TypeWork'";
            var works = await _db.Work.FromSqlRaw(query, "public.Work").ToListAsync();

            


            return works; 
            
        }


        public async Task<List<Work>> Select()
        {

            List<Work> works = await _db.Work.ToListAsync(); //удалил 140824 1-16
            return works;  //удалил 140824 1-16сделали метод асинхронным, чтобы сайт не завис во время получения данных 
           
        }

        public async Task<bool> DeleteAsync(Work entity) // 140824 2-22 public bool Delete(Car entity)
        {
            _db.Work.Remove(entity);
            await _db.SaveChangesAsync(); // 140824 2-25
            return true;//чтобы изменения в бд сохранились
        }

        public async Task<Work> GetByNameAsync(string name)  // public async Task<Car> GetByNameAsync(string name)
        {
           
            return await _db.Work.FirstOrDefaultAsync(x => x.NameTask == name);
        }

        async Task<bool> IBaseRepository<Work>.Delete(Work entity)
        {
            _db.Work.Remove(entity);
            await _db.SaveChangesAsync(); // 140824 2-25
            return true;
           
        }

        public async Task<bool> UpdateAsync(Work entity)
        {
            _db.Work.Update(entity);
            
            await _db.SaveChangesAsync();//140824 2-25 await _db.SaveChangesAsync();//await _db.SaveChangesAsync();//dataManager.ServiceItems.SaveServiceItem(model);
            return true;
        }








       
    }
}
