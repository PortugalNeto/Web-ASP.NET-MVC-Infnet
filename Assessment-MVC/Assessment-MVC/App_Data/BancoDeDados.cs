using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment_MVC.Models;

namespace Assessment_MVC.App_Data
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options)
        {
        }

        //representa a tabela!!
        public DbSet<Amigo> Amigos { get; set; }
    }
}
