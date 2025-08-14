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


        [HttpGet]
        public async Task<IActionResult> GetWorks()
        {
            

            var work = new Work()
            {
                NameTask = "Восстановить ПК продавца",   
                TaskNumber = 3928,
                Description = "не запускается компьютер продавца",
                Customer = "Линии любви",
                AdressTask = "г. Орёл, ул. Революции, 38",
                Price = 1500,                
                TypeWork = TypeWork.Free
            };


            await _workRepository.Create(work); 

            var work1 = new Work()
            {

                NameTask = "Подключить МФУ",   
                TaskNumber = 3029,
                Description = "Подключить новый МФУ на рабочее место заведующиго",
                Customer = "Линии любви",
                AdressTask = "г. Ульяновск, ул. Республики, 8",
                Price = 1900,
                
                TypeWork = TypeWork.Free
            };


            await _workRepository.Create(work1);
           
            var responseSelect = await _workRepository.Select();

            return View(responseSelect); 
            
        }
    }
}
