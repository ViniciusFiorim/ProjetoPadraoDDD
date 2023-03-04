using AutoMapper;
using Domain.Entities.Cliente;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.AutoMapper
{
    public class ClienteDomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ClienteDomainToViewModelMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
        }
    }
}