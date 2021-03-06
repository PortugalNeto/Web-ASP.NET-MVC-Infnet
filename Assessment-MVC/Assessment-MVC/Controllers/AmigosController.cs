using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_MVC.Models;
using Assessment_MVC.App_Data;

namespace Assessment_MVC.Controllers
{
    public class AmigosController : Controller
    {
        public AmigosController(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        private BancoDeDados BancoDeDados { get; set; }

        [HttpGet]
        public IActionResult Index(string nome)
        {
            List<Amigo> amigos;
            if (string.IsNullOrWhiteSpace(nome))
            {
                amigos = BancoDeDados.Amigos.ToList();
                return View(amigos);
            }
            amigos = BancoDeDados.Amigos.Where(aluno => aluno.nome.Contains(nome)).ToList();
            return View(amigos);

        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string nome, string email, string sobrenome, DateTime aniversario)
        {

            var amigo = new Amigo
            {
                nome = nome,
                sobrenome = sobrenome,
                aniversario = aniversario
            };

            BancoDeDados.Add(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("/amigos/index");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            return View(amigo);
        }

        [HttpPost]
        public ActionResult Editar(int id, string nome, string sobrenome, DateTime aniversario)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            amigo.nome = nome;
            amigo.sobrenome = sobrenome;
            amigo.aniversario = aniversario;

            BancoDeDados.Amigos.Update(amigo);
            BancoDeDados.SaveChanges();
            return Redirect("/amigos/index");
        }

        [HttpGet]
        public ActionResult Excluir (int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);

            return View(amigo);
        }

        [HttpPost]
        public ActionResult ExcluirConfirma(int id)
        {
            var amigo = BancoDeDados.Amigos.Find(id);


            BancoDeDados.Amigos.Remove(amigo);
            BancoDeDados.SaveChanges();
            return Redirect("/amigos/index");
        }
    }
}
