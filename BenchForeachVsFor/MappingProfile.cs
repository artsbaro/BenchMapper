using AutoMapper;
using BenchMapper.Models;

namespace BenchMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Definir o mapeamento entre ComandoEmAcao e ComandoEmAcaoDto
            CreateMap<ComandoEmAcao, ComandoEmAcaoDTO>();
            CreateMap<ComandoFesta, ComandoFestaDTO>();
            CreateMap<ComandoDelta, ComandoDeltaDTO>();
            CreateMap<AcoesComando, AcoesComandoDTO>();
            CreateMap<Comando, ComandoDTO>();
        }
    }
}
