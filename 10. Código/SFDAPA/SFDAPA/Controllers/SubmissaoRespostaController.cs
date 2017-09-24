using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace SFDAPA.Controllers
{
    public class SubmissaoRespostaController : Controller
    {
        private GerenciadorSubmissaoResposta gerenciador;
        
        public SubmissaoRespostaController()
        {
            gerenciador = new GerenciadorSubmissaoResposta();
        }

        // GET: SubmissaoResposta
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubmissaoResposta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubmissaoResposta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubmissaoResposta/Create
        [HttpPost]
        public ActionResult Create(SubmissaoResposta submissaoResposta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(submissaoResposta);
                    RedirectToAction("Index");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SubmissaoResposta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubmissaoResposta/Edit/5
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

        // GET: SubmissaoResposta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubmissaoResposta/Delete/5
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
