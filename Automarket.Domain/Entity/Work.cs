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
                
        public string NameTask { get; set; }  //имя заявки
        public int TaskNumber { get; set; } //номер заявки
        public string Description { get; set; } //описание заявки
             
        public string Customer {  get; set; } //заказчик
            
        public string AdressTask { get; set; } //адрес выполнения заявки
        public decimal  Price { get; set; }
            
        public TypeWork TypeWork { get; set; } //статус заявки


    }
}
