using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Domain.Entities.Produto;
using Infra.Data.Repositories;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoRepository _produtoRepository = new ProdutoRepository();
        
        [HttpGet]
        public ActionResult Index()
        {
            var  produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAll());
            return View(produtoViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoRepository.Add(produtoDomain);

                return RedirectToAction("Index");
            }

            return View(produto);
        }
    }
}