using AutoMapper;

namespace ProjetoModeloDDD.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(mp =>
            {
                mp.AddProfile<ClienteDomainToViewModelMappingProfile>();
                mp.AddProfile<ClienteViewModelToDomainMappingProfile>();
                mp.AddProfile<ProdutoDomainToViewModelMappingProfile>();
                mp.AddProfile<ProdutoViewModelToDomainMappingProfile>();
            });
            
        }
    }
}