using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1.Data
{
    public class Taask
    {
        public int TaaskId { get; set; }
        [Required]                      //point 6
        public string TaaskTitle { get; set;}

        public string TaaskDescription { get; set; } 
        public DateTime TaaskDate { get; set; }

    }
}
