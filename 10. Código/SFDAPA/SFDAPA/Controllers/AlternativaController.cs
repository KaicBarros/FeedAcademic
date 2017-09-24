using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class AlternativaController : Controller
    {
        private GerenciadorAlternativa gerenciador;

        public AlternativaController()
        {
            gerenciador = new GerenciadorAlternativa();
        }
        // GET: Alternativa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Alternativa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alternativa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alternativa/Create
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

        // GET: Alternativa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alternativa/Edit/5
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

        // GET: Alternativa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alternativa/Delete/5
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
