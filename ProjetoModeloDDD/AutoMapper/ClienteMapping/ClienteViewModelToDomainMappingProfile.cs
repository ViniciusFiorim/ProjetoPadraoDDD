using AutoMapper;
using Domain.Entities.Cliente;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.AutoMapper
{
    public class ClienteViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ClienteViewModelToDomainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
        }
    }
}