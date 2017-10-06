using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class AssuntoController : Controller
    {
        private GerenciadorAssunto gerenciador;

        public AssuntoController()
        {
            gerenciador = new GerenciadorAssunto();
        }

        // GET: Assunto
        public ActionResult Index()
        {
            return View(gerenciador.ObterTodos());
        }

        // GET: Assunto/Details/5
        public ActionResult Details(int id)
        {
            return View(gerenciador.Obter(id));
        }

        // GET: Assunto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assunto/Create
        [HttpPost]
        public ActionResult Create(Assunto assunto)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(assunto);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
            }
            return View();
        }

        // GET: Assunto/Edit/5
        public ActionResult Edit(int id)
        {
            return View(gerenciador.Obter(id));
        }

        // POST: Assunto/Edit/5
        [HttpPost]
        public ActionResult Edit(Assunto assunto)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Editar(assunto);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
            }
            return View();
        }

        // GET: Assunto/Delete/5
        public ActionResult Delete(int id)
        {
             return View(gerenciador.Obter(id));
        }

        // POST: Assunto/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Assunto assunto = new Assunto();
                TryUpdateModel(assunto, collection.ToValueProvider());
                gerenciador.Remover(assunto);
                return RedirectToAction("Index", "Assunto");
            }
            catch
            {
                return View();
            }
        }
    }
}
