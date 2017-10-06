using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class ProfessorController : Controller
    {

        private GerenciadorProfessor gerenciador;

        public ProfessorController()
        {
            gerenciador = new GerenciadorProfessor();
         }

        // GET: Professor
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Turma");
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            Professor professor = gerenciador.Obter(id);
            return View(professor);
        }

        // GET: Professor/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        public ActionResult Create(Professor professor)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(professor);
                    RedirectToAction("Listar");
                }
            }
            catch
            {
            }
            return View();
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            Professor professor = gerenciador.Obter(id);
            return View(professor);
        }

        // POST: Professor/Edit/5
        [HttpPost]
        public ActionResult Edit(Professor professor)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    Professor professorAux = gerenciador.Obter(professor.Codigo);
                    professorAux.Email = professor.Email;
                    professorAux.Instituição = professor.Instituição;
                    professorAux.Nome = professor.Nome;
                    professorAux.Senha = professor.Senha;
                    gerenciador.Editar(professor);
                    return RedirectToAction("Listar");
                }
            }
            catch
            {
            }
            return View();
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(int id)
        {
            Professor professor = gerenciador.Obter(id);
            return View(professor);
        }

        // POST: Professor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Professor professor = gerenciador.Obter(id);
                gerenciador.Remover(professor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Listar()
        {
            return View(gerenciador.ObterTodos());
        }
    }
}
