using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class TurmaController : Controller
    {
        private GerenciadorTurma gerenciador;
        private List<Turma> turmas;
        private Turma turma;

        public TurmaController()
        {
            gerenciador = new GerenciadorTurma();
        }

        // GET: Turma
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {  
            turmas = gerenciador.ObterTodos();
            return View(turmas);
        }

        // GET: Turma/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Turma/Create
        [HttpPost]
        public ActionResult Create(Turma turma)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(turma);
                    RedirectToAction("Listar");

                }
                // TODO: Add insert logic here
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: Turma/Edit/5
        public ActionResult Edit(int id)
        {
            Turma turma = gerenciador.Obter(id);

            return View(turma);
        }

        // POST: Turma/Edit/5
        [HttpPost]
        public ActionResult Edit(Turma turma)
        {
            try
            {
                // TODO: Add update logic here
                Turma turmaAux = gerenciador.Obter(turma.Codigo);
                turmaAux.NomeTurma = turma.NomeTurma;
                turmaAux.EmailProfessor = turma.EmailProfessor;
                gerenciador.Editar(turmaAux);
                return RedirectToAction("Listar");
            }
            catch
            {
                return View(turma);
            }
        }

        // GET: Turma/Delete/5
        public ActionResult Delete(int id)
        {
            Turma turmaAux = gerenciador.Obter(id);
            return View(turmaAux);
        }

        // POST: Turma/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Turma turmaAux = gerenciador.Obter(id);
                gerenciador.remover(turmaAux);
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }
    }
}
