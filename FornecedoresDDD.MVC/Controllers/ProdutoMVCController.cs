using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Interfaces;
using FornecedoresDDD.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FornecedoresDDD.MVC.Controllers
{
    public class ProdutoMVCController : Controller
    {
        private readonly ProdutoAppInterface _produtoAppInterface;

        public ProdutoMVCController(ProdutoAppInterface produtoAppInterface)
        {
            _produtoAppInterface = produtoAppInterface;
        }

        // GET: ProdutoMVC
        public ActionResult Index()
        {
            return View(_produtoAppInterface.Listar());
        }

        // GET: ProdutoMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutoMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                produto.Id = Guid.NewGuid();
                _produtoAppInterface.Adicionar(produto);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: ProdutoMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}