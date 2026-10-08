using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itmytask.Domain.Enum;

namespace Itmytask.Domain.Entity
{
    public class Work
    {
        public int Id { get; set; }     
        ///имя заявки
        public string NameTask { get; set; }  
        ///номер заявки
        public int TaskNumber { get; set; }
        ///описание заявки    
        public string Description { get; set; }
        ///заказчик  
        public string Customer {  get; set; }
        ///адрес выполнения заявки
        public string AdressTask { get; set; } 
        public decimal  Price { get; set; }
        ///статус заявки
        public TypeWork TypeWork { get; set; } 
    }
}
