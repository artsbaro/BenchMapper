namespace BenchMapper.Models
{
    public class ComandoEmAcaoDTO : ComandoDTO
    {
        public string? Nome { get; set; }
        public int Quantidade { get; set; }

        public ComandoEmAcaoDTO()
        {
            Tipo = "Em Ação";
        }
    }

    public class ComandoFestaDTO : ComandoDTO
    {
        public string? Endereco { get; set; }
        public string? Coordenadas { get; set; }

        public bool? Codigo { get; set; } = false;

        public ComandoFestaDTO()
        {
            Tipo = "Festa";
        }
    }

    public class ComandoDeltaDTO : ComandoDTO
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? QG { get; set; }

        public ComandoDeltaDTO()
        {
            Tipo = "Delta";
        }
    }

}
