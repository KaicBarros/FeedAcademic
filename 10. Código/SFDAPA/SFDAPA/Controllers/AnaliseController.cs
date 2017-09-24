using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class AnaliseController : Controller
    {
        private GerenciadorAnalise gerenciador;

        public AnaliseController()
        {
            gerenciador = new GerenciadorAnalise();
        }

        // GET: Analise
        public ActionResult Index()
        {
            return View();
        }

        // GET: Analise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Analise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Analise/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Analise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Analise/Edit/5
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

        // GET: Analise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Analise/Delete/5
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
