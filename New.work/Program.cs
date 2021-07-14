using System;

namespace New.work
{
    class Program
    {
        static Serie.Repositorio Repositorio = new Serie.Repositorio();

        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X")
            {
              {switch (OpcaoUsuario)}

              {
                  case "1":
                  ListarSeries();
                  break;
                  case "2":
                  InserirSerie();
                  break;
                  case "3":
                  AtualizarSerie();
                  break;
                  case "4":
                  ExcluirSerie();
                  break;
                  case "5":
                  VisualizarSerie();
                  break;
                  case "C":
                  Console.Clear();
                  break;
            
                  default: 
                    throw new ArgumentOutOfRangeException();
              }
            }  
         }

        }
        private static string ObterOpcaoUsuario()

        {Console.WriteLine("Obrigado por utilizar os nossos serviços!");
        Console.ReadLine();
        }

        private static void ListarSeries();
        {
            Console.WriteLine("ListarSeries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return
            }
            foreach (var Serie in lista)
            {
                var Excluido = serie.retornaExcluido();
                
                Console.WriteLine('#ID {0}: - {1}', serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }

        }
        private static void InserirSerie();
        {
            Console.WriteLine("Inserir nova Série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine('#ID {0}: - {1}', i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite os gêneros entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da Série: ");
            string EntradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de início da Série: ");
            int EntradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da Série: ");
            string EntradaDescricao = Console.ReadLine();

            Serie = new Serie(id: repositorio.ProximoId();
                        Genero: (Genero)EntradaGenero;
                        Titulo: EntradaTitulo;
                        Ano: EntradaAno;
                        Descricao: EntradaDescricao;
            
            repositorio.Insere(novaSerie);

        }
        private static void AtualizarSerie();
        {
            Console.Write("Digite o ID da Série: ");
            int IndicaSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine('#ID {0}: - {1}', i, Enum.GetName(typeof(Genero));
            }

            Console.Write("Digite os gêneros entre as opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da Série: ");
            string EntradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de início da Série: ");
            int EntradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da Série: ");
            string EntradaDescricao = Console.ReadLine();

            Serie AtualizaSerie = new Serie(id: repositorio.ProximoId();
                        Genero: (Genero)EntradaGenero;
                        Titulo: EntradaTitulo;
                        Ano: EntradaAno;
                        Descricao: EntradaDescricao;

                        repositorio.Atualiza(indicaSerie, atualizaSerie);

        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o ID da Série: ");
            int indicaSerie = int.Parse(Console.ReadLine());

            var Serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        {
        Console.WriteLine();
        Console.WriteLine("Tenha as melhores series aqui!");
        Console.WriteLine("Informe a opção desejada: ");
        
        Console.WriteLine("1 - Listar séries");
        Console.WriteLine("2 - Inserir nova série");
        Console.WriteLine("3 - Atualizar série");
        Console.WriteLine("4 - Excluir série");
        Console.WriteLine("5 - Visualizar série");
        Console.WriteLine("C - Limpar tela");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string OpcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return OpcaoUsuario;
        }
    }

}
