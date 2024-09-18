namespace BenchMapper.Models
{
    public class ComandoEmAcao : Comando
    {
        public string? Nome { get; set; }
        public int Quantidade { get; set; }

        public ComandoEmAcao()
        {
            Tipo = "Em Ação";
        }
    }

    public class ComandoFesta : Comando
    {
        public string? Endereco { get; set; }
        public string? Coordenadas { get; set; }

        public bool? Codigo { get; set; } = false;

        public ComandoFesta()
        {
            Tipo = "Festa";
        }
    }

    public class ComandoDelta : Comando
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? QG { get; set; }

        public ComandoDelta()
        {
            Tipo = "Delta";
        }
    }

}
