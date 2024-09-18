// See https://aka.ms/new-console-template for more information
using BenchMapper.Models;
using BenchMapper;
using BenchmarkDotNet.Running;

Console.WriteLine("### Usando BenchmarkDotNet  ###\n");
Console.WriteLine("Pressione algo para iniciar\n");
Console.ReadLine();

//AcoesComando comandos = new AcoesComando
//{
//    Comandos = new List<Comando>
//    {
//        new ComandoEmAcao { Tipo = "Em Ação", Nome = "Operação Tempestade", Quantidade = 50 },
//        new ComandoFesta { Tipo = "Festa", Endereco = "Rua das Flores, 123", Coordenadas = "-23.550520, -46.633308", Codigo = true },
//        new ComandoDelta { Tipo = "Delta", Nome = "Comando Secreto", Idade = 35, QG = "Base Subterrânea" }
//    }
//};

//var resultado1 = new BenchmarkMapper();
//var obj = resultado1.ExecutandoMapperComAutoMapper();


//Console.ReadLine();


var resultado =
   BenchmarkRunner.Run<BenchmarkMapper>();
