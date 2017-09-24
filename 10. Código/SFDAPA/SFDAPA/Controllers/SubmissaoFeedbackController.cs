using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class SubmissaoFeedbackController : Controller
    {
        private GerenciadorSubmissaoFeedback gerenciador;
        
        public SubmissaoFeedbackController()
        {
            gerenciador = new GerenciadorSubmissaoFeedback();
        }
        
        // GET: SubmissaoFeedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubmissaoFeedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubmissaoFeedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubmissaoFeedback/Create
        [HttpPost]
        public ActionResult Create(SubmissaoFeedback submissaoFeedback)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(submissaoFeedback);
                    RedirectToAction("Index");
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SubmissaoFeedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubmissaoFeedback/Edit/5
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

        // GET: SubmissaoFeedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubmissaoFeedback/Delete/5
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
