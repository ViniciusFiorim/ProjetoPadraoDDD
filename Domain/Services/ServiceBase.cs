using System;
using System.Collections.Generic;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ServiceBase<TEmtity> : IDisposable, IServiceBase<TEmtity> where TEmtity : class
    {
        private readonly IRepositoryBase<TEmtity> _repository;

        public ServiceBase(IRepositoryBase<TEmtity> repository)
        {
            _repository = repository;
        }

        public void Add(TEmtity obj)
        {
            _repository.Add(obj);
        }

        public TEmtity GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public IEnumerable<TEmtity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEmtity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEmtity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}