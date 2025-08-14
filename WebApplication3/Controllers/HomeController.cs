﻿using Itmytask.DAL;
using Itmytask.DAL.Interfaces;
using Itmytask.DAL.Repositories;
using Itmytask.Domain.Entity;
using Itmytask.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using WebApplication3.Models;


namespace Itmytask.Controllers 
{
    public class HomeController : Controller
    {
        private readonly IWorkRepository _workRepository; 

        public HomeController(IWorkRepository workRepository) 
        {
            _workRepository = workRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
        {

            return View();
        }   
        public async Task<IActionResult> GetPosition()
        {
            
            var responseSelect = await _workRepository.Select();
            return View(responseSelect);
        }
        [HttpGet]
        public async Task<IActionResult> Privacy()
        {
          
            var responseSelect = await _workRepository.Select();
            Work work = new Work() 
            {
                NameTask = "Настроить камеру",  
                TaskNumber = 1000,
                Description = "настроить камеру 8, после выполнение позвонить в техподдержку",
                Customer = "Линии любви",
                AdressTask = "г. Орёл, ул. Революции, 38",
                Price = 1500,
                
                TypeWork = TypeWork.Free
            };
            
            return View(responseSelect);
            
        }
        public IActionResult NewCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewCreate(Work work)
        {

            await _workRepository.Create(work);
           

            var responseSelect = await _workRepository.Select();
       

            return RedirectToAction("GetPosition");
            ;
        }

        [HttpPost] 
        public async Task<IActionResult> PostDelete(int id)
        {
            if (id != null)
            {
                Work work = await _workRepository.GetAsync(id); 
                if (work != null) 
                {
                    var responseSelect = await _workRepository.Delete(work);
                    return RedirectToAction("GetPosition");
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> PostEdit(int id)
        {
            if (id != null)
            {
                Work? work = await _workRepository.GetAsync(id);
                if (work != null) return View(work);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PostEdit(Work work)
        {
            var responseSelect = await _workRepository.UpdateAsync(work);
            return RedirectToAction("GetPosition");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
