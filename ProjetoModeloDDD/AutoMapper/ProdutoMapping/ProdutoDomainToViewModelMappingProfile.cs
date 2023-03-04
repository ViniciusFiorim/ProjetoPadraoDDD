using AutoMapper;
using Domain.Entities.Produto;
using ProjetoModeloDDD.ViewModels;

namespace ProjetoModeloDDD.AutoMapper
{
    public class ProdutoDomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ProdutoDomainToViewModelMapping";  }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}