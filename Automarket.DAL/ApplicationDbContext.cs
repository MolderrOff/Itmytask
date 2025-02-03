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
        //------
            //-----
        {
            Database.EnsureCreated(); //140824 0 06 устанавливает связь с БД, создаёт базу данных если не создана
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder//.LogTo(Console.WriteLine)
                 //.UseLazyLoadingProxies()
                 //.UseNpgsql(
                    //"Server:localhost; Database:TaskPrice; UserId:root; Password:ghgkyUYTUY456;"
            //@"Server:127.0.0.1; Database:usersdb; User Id:root; Password:ghgkyUYTUY456; SslMode:0"
            //"Host = localhost; Username = usertest; Password = 12345678; Port = 3306"
            //"Host = 37.143.10.243; Username = usertest; Password = 12345678; Database = myproject; Port = 3306"

            //"Host = localhost; Username = postgres; Password = postgres; Database = TaskPrice2;"
            //образец:
            //"Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=пароль_от_postgres"
            //);
            .UseMySql("Host = localhost; Port=3306; Database = TaskPrice;  Username = root; Password = ghgkyUYTUY456;",
            new MySqlServerVersion(new Version(8, 0, 40)));

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host = localhost; Username = postgres; Password = example; Database = TaskPrice;");
        //}
        public DbSet<Work> Work { get; set; }  //в эту сущность будут вставляться данные из нашей таблицы
    }
}
