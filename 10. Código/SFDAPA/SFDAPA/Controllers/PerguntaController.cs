using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class PerguntaController : Controller
    {
        private GerenciadorPergunta gerenciador;

        public PerguntaController()
        {
            gerenciador = new GerenciadorPergunta();
        }

        // GET: Pergunta
        public ActionResult Index()
        {
            return View();
        }
 
        // GET: Pergunta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pergunta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pergunta/Create
        [HttpPost]
        public ActionResult Create(Pergunta pergunta)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(pergunta);
                    RedirectToAction("Index");

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pergunta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pergunta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pergunta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pergunta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
