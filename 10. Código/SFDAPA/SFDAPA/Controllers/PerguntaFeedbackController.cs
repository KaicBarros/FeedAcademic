using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class PerguntaFeedbackController : Controller
    {
        private GerenciadorPerguntaFeedback gerenciador;

        public PerguntaFeedbackController()
        {
            gerenciador = new GerenciadorPerguntaFeedback();
        }
        
        // GET: PerguntaFeedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: PerguntaFeedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PerguntaFeedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerguntaFeedback/Create
        [HttpPost]
        public ActionResult Create(PerguntaFeedback perguntaFeedback)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(perguntaFeedback);
                    RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PerguntaFeedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PerguntaFeedback/Edit/5
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

        // GET: PerguntaFeedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PerguntaFeedback/Delete/5
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
