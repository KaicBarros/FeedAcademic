using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
namespace SFDAPA.Controllers
{
    public class AlunoController : Controller
    {
        private GerenciadorAluno gerenciador;
        private List<Aluno> alunos;
        private int aluno;

        public AlunoController()
        {
            gerenciador = new GerenciadorAluno();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            alunos = gerenciador.ObterTodos();
            return View(alunos);
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View(gerenciador.Obter(id));
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(aluno);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
            }
            return View();
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View(gerenciador.Obter(id));
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        public ActionResult Edit(Aluno aluno)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Editar(aluno);
                    return RedirectToAction("Index");
                }

            }
            catch
            {
            }
            return View();

        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(gerenciador.Obter(id));
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Aluno aluno = new Aluno();
                TryUpdateModel(aluno, collection.ToValueProvider());
                gerenciador.Remover(aluno);
                return RedirectToAction("Index","Aluno");
            }
            catch
            {
                return View();
            }
        }
    }
}
