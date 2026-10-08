using System.ComponentModel.DataAnnotations;

namespace Itmytask.Domain.Enum
{
    public enum TypeWork  
    {
        [Display(Name = "Свободна")]
        Free = 0,
        [Display(Name = "Принята в работу")]
        Taken = 1,
        [Display(Name = "Работы завершены")]
        Completed = 2
    }
}