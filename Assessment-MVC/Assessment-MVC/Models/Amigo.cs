using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_MVC.Models
{
    public class Amigo
    {
        public int AmigoId { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public DateTime aniversario { get; set; }
    }
}
