using System.Collections.Generic;
using System.Web.Mvc;
using Application.Interface;
using AutoMapper;
using Domain.Entities.Produto;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;

        public ProdutosController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var  produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }
        
        public ActionResult Create() 
        {
            ViewBag.Message = "Novo produto";
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            return View(produto);
        }
    }
}