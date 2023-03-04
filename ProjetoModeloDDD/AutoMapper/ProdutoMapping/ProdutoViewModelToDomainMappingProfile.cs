using AutoMapper;
using Domain.Entities.Produto;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.AutoMapper
{
    public class ProdutoViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ProdutoViewModelToDomainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}