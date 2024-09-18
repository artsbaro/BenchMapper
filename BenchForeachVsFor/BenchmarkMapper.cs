using BenchmarkDotNet.Attributes;
using System.Text.Json.Serialization;
using AutoMapper;
using Microsoft.CodeAnalysis.FlowAnalysis;
using BenchMapper.Models;
using Mapster;

namespace BenchMapper
{
    [MemoryDiagnoser]
    public class BenchmarkMapper
    {
        private readonly IMapper _mapper;
        private AcoesComando _comandos;

        public BenchmarkMapper()
        {
            var configAutoMapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configAutoMapper.CreateMapper();

            _comandos = new AcoesComando
            {
                Comandos = new List<Comando>
                {
                    new ComandoEmAcao { Tipo = "Em Ação", Nome = "Operação Tempestade", Quantidade = 50 },
                    new ComandoFesta { Tipo = "Festa", Endereco = "Rua das Flores, 123", Coordenadas = "-23.550520, -46.633308", Codigo = true },
                    new ComandoDelta { Tipo = "Delta", Nome = "Comando Secreto", Idade = 35, QG = "Base Subterrânea" }
                }
            };
        }

        [Benchmark]
        public AcoesComandoDTO ExecutandoMapperManual()
        {
            var acoesComandoDto = new AcoesComandoDTO
            {
                Comandos = new List<ComandoDTO>()
            };

            foreach (var comando in _comandos.Comandos)
            {
                switch (comando)
                {
                    case ComandoEmAcao comandoEmAcao:
                        {
                            // Mapeamento manual para ComandoEmAcaoDTO
                            var comandoDto = new ComandoEmAcaoDTO
                            {
                                Tipo = comandoEmAcao.Tipo,
                                Nome = comandoEmAcao.Nome,
                                Quantidade = comandoEmAcao.Quantidade
                            };
                            acoesComandoDto.Comandos.Add(comandoDto);
                            break;
                        }

                    case ComandoFesta comandoFesta:
                        {
                            // Mapeamento manual para ComandoFestaDTO
                            var comandoDto = new ComandoFestaDTO
                            {
                                Tipo = comandoFesta.Tipo,
                                Endereco = comandoFesta.Endereco,
                                Coordenadas = comandoFesta.Coordenadas,
                                Codigo = comandoFesta.Codigo
                            };
                            acoesComandoDto.Comandos.Add(comandoDto);
                            break;
                        }

                    case ComandoDelta comandoDelta:
                        {
                            // Mapeamento manual para ComandoDeltaDTO
                            var comandoDto = new ComandoDeltaDTO
                            {
                                Tipo = comandoDelta.Tipo,
                                Nome = comandoDelta.Nome,
                                Idade = comandoDelta.Idade,
                                QG = comandoDelta.QG
                            };
                            acoesComandoDto.Comandos.Add(comandoDto);
                            break;
                        }
                }
            }

            return acoesComandoDto;
        }

        [Benchmark]
        public AcoesComandoDTO ExecutandoMapperComAutoMapper()
        {
            // Mapeamento usando AutoMapper
            return _mapper.Map<AcoesComandoDTO>(_comandos);
        }

        [Benchmark]
        public AcoesComandoDTO ExecutandoMapperComMapster()
        {
            return _comandos.Adapt<AcoesComandoDTO>();
        }
    }
}
