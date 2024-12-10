using Itmytask.DAL.Interfaces;
using Itmytask.DAL.Repositories;
using Itmytask.Domain.Entity;
using Itmytask.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itmytask.Controllers
{
    public class WorkController : Controller
    {
        private readonly IWorkRepository _workRepository;

        public WorkController(IWorkRepository workRepository)
        {
            _workRepository = workRepository;
        }


        [HttpGet] //атрибут на метод действия
        public async Task<IActionResult> GetWorks()
        {
            //var response = await _workRepository.Select(); //было var response = await _carRepository.Select();
            //var response1 =  await _workRepository.GetByNameAsync("BMWX5");//var response1 = await _carRepository.GetByName("BMWX5");
            //var response2 = await _workRepository.GetAsync(3);// var response2 =  _carRepository.GetAsync(3);
            //var responseSelect = db.Companies.FromSqlRaw("SELECT * FROM Companies").ToList();
            //var responseSelect = await _carRepository.GetAsyncSelect(); //----->> 150824

            var work = new Work()
            {
                NameTask = "Восстановить ПК продавца",   //он зависит от car.cs в енампе (перечислении)
                TaskNumber = 3028,
                Description = "не запускается компьютер продавца",
                Customer = "Линии любви",
                AdressTask = "г. Орёл, ул. Революции, 38",
                Price = 1500,
                //StatusTask = "в работе",
                DateCreate = DateTime.Now,
                TypeWork = TypeWork.Free
            };


            await _workRepository.Create(work); //var response3 =  await _carRepository.Create(car);
                                              //await _carRepository.Delete(car);

            var work1 = new Work()
            {

                NameTask = "Подключить МФУ",   //он зависит от car.cs в енампе (перечислении)
                TaskNumber = 3029,
                Description = "Подключить новый МФУ на рабочее место заведующиго",
                Customer = "Линии любви",
                AdressTask = "г. Ульяновск, ул. Республики, 8",
                Price = 1900,
                //StatusTask = "в работе",
                DateCreate = DateTime.Now,
                TypeWork = TypeWork.Free
            };


            await _workRepository.Create(work1);
            //await _carRepository.Delete(car1);

            var responseSelect = await _workRepository.GetAsyncSelect(); //----->> 071224
            
            return View(responseSelect); //response будт храниться писок объектов из нашей бд
            
        }
    }
}
