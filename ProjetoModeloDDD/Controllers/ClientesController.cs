using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Domain.Entities.Cliente;
using Infra.Data.Repositories;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();
        
        [HttpGet]
        public ActionResult Index()
        {
            var  clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.GetAll());
            return View(clienteViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteRepository.Add(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }
    }
}