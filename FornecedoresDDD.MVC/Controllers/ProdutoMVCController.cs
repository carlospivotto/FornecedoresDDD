using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Interfaces;
using AutoMapper;
using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FornecedoresDDD.MVC.Controllers
{
    public class ProdutoMVCController : Controller
    {
        private readonly IProdutoApp _produtoApp;
        private readonly IMapper _mapper;

        public ProdutoMVCController(IProdutoApp produtoApp, IMapper mapper)
        {
            _produtoApp = produtoApp;
            _mapper = mapper;

        }

        // GET: ProdutoMVC
        public ActionResult Index()
        {
            var produtos = _mapper.Map<ProdutoViewModel>(_produtoApp.Listar());
            return View(produtos);
        }

        // GET: ProdutoMVC/Details/5
        public ActionResult Details(Guid id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(_produtoApp.RecuperarPorId(id));
            return View(produto);
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
                _produtoApp.Adicionar(produto);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: ProdutoMVC/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_produtoApp.RecuperarPorId(id));
        }

        // POST: ProdutoMVC/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                // TODO: Add update logic here
                _produtoApp.Atualizar(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoMVC/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_produtoApp.RecuperarPorId(id));
        }

        // POST: ProdutoMVC/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Produto produto)
        {
            try
            {
                // TODO: Add delete logic here
                _produtoApp.Excluir(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}