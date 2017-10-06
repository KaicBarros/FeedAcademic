using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using SFDAPA.Util;

namespace SFDAPA.Controllers
{
    public class AulaController : Controller
    {
        private GerenciadorAula gerenciador;

        public AulaController()
        {
            gerenciador = new GerenciadorAula();
        }

        // GET: Aula
        public ActionResult Index()
        {
            List<Aula> aulas = gerenciador.ObterTodos();
            return View(aulas);
        }

        // GET: Aula/Details/5
        public ActionResult Details(int id)
        {
            Aula aula = gerenciador.Obter(id);
            return View(aula);
        }

        // GET: Aula/Create
        public ActionResult Create()
        {

            GerenciadorTurma turma = new GerenciadorTurma();
            List<Turma> turmas = turma.ObterTodos();
            List<SelectListItem> itens = new List<SelectListItem>();
            itens.Add(new SelectListItem { Text = "Selecione a Turma", Value = "0", Selected = true });

            for (int i = 0; i < turmas.Count; i++)
            {
                itens.Add(new SelectListItem { Text = (turmas[i].Codigo + " - " + turmas[i].NomeTurma), Value = ""+turmas[i].Codigo });
            }

            ViewBag.Turma = itens;
            return View();
        }

        // POST: Aula/Create
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            try
            {
                
                Aula aula = new Aula();
                aula.Codigo = Int32.Parse(form["Codigo"]);
                aula.Data = Convert.ToDateTime(form["Data"]);
                aula.Título = form["Título"];

                
                int idTurma = 0;

                try
                {
                    idTurma = Int32.Parse(form["Turma"]);
                }
                catch (Exception ex)
                {
                }

                GerenciadorTurma turmas = new GerenciadorTurma();
                
                if (idTurma != 0)
                {
                    aula.turma = turmas.Obter(idTurma);
                    gerenciador.Adicionar(aula);
                }


                return RedirectToAction("Index");

                // TODO: Add insert logic here
                /*
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(aula);
                    return RedirectToAction("Index");
                } */
            }
            catch
            {
            }
            return View();
        }

        // GET: Aula/Edit/5
        public ActionResult Edit(int id)
        {
            Aula aula = gerenciador.Obter(id);
            return View(aula);
        }

        // POST: Aula/Edit/5
        [HttpPost]
        public ActionResult Edit(Aula aula)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    Aula aulaAux = gerenciador.Obter(aula.Codigo);
                    aulaAux.Data = aula.Data;
                    aulaAux.Título = aula.Título;
                    gerenciador.Editar(aula);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
            }
            return View();

        }

        // GET: Aula/Delete/5
        public ActionResult Delete(int id)
        {
            Aula aula = gerenciador.Obter(id);
            return View(aula);
        }

        // POST: Aula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Aula aula = gerenciador.Obter(id);
                gerenciador.Remover(aula);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
