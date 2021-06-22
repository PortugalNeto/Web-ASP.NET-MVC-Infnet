using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_MVC.Models
{
    public class HomeModel
    {

        public List<Amigo> Amigos { get; set; } = new List<Amigo>();

        public List<DateTime> Aniversariantes { get; set; } = new List<DateTime>();
    }
}
