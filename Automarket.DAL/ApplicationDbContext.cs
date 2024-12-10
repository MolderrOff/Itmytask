using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itmytask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Itmytask.DAL          //Берёт из базы данных и превращает в объект  car на C#
{
    public class ApplicationDbContext : DbContext //позволяет возможность использовать все из Entity Framework
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        //сам конструктор принимает generic объект options

        {
            Database.EnsureCreated(); //140824 0 06 устанавливает связь с БД, создаёт базу данных если не создана
        }

        public DbSet<Work> Work { get; set; }  //в эту сущность будут вставляться данные из нашей таблицы
    }
}
