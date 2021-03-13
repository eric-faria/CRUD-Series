using System;

namespace CRUD_Series
{
    class Program
    {
        static SerieRepositorio Repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string OpcaoUsr = ObterOpcaoUsr();

            while (OpcaoUsr.ToUpper() != "X")
            {
                switch (OpcaoUsr)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                OpcaoUsr = ObterOpcaoUsr();
            }
        }

        private static void VisualizarSeries()
        {
            System.Console.WriteLine("Informe o ID: ");
            int IdSerie = int.Parse(Console.ReadLine());

            var Serie = Repositorio.RetornaPorId(IdSerie);
            System.Console.WriteLine(Serie);
        }

        private static void ExcluirSeries()
        {
            System.Console.WriteLine("Informe o ID: ");
            int IdSerie = int.Parse(Console.ReadLine());

            Repositorio.Exclui(IdSerie);
        }

        private static void AtualizarSeries()
        {
            System.Console.WriteLine("Informe o ID: ");
            int IdSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("Escolha o genênero: ");
                int EntradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Informe o título: ");
                string EntradaTitulo = Console.ReadLine();

                System.Console.WriteLine("Ano: ");
                int EntradaAno = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Descrição :");
                string EntradaDescricao = Console.ReadLine();

                Serie NovaSerie = new Serie (Id: IdSerie, Genero: (Genero)EntradaGenero, Titulo: EntradaTitulo, Ano: EntradaAno, Descricao:EntradaDescricao);

                Repositorio.Atualiza(IdSerie, NovaSerie);
            }
        }

    

        private static void InserirSeries()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("Escolha o genênero: ");
                int EntradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Informe o título: ");
                string EntradaTitulo = Console.ReadLine();

                System.Console.WriteLine("Ano: ");
                int EntradaAno = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Descrição :");
                string EntradaDescricao = Console.ReadLine();

                Serie NovaSerie = new Serie (Id: Repositorio.ProximoId(), Genero: (Genero)EntradaGenero, Titulo: EntradaTitulo, Ano: EntradaAno, Descricao:EntradaDescricao);

                Repositorio.Insere(NovaSerie);
            }
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Lista de Séries");
            var Lista = Repositorio.Lista();

            if (Lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var Serie in Lista)
            {
                var Excluido = Serie.RetornaExcluido();
                if (!Excluido)
                {
                    System.Console.WriteLine("#ID {0} - {1}", Serie.RetornaID(), Serie.RetornaTitulo());
                }
            }
        }

        private static string ObterOpcaoUsr()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine();

            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2- Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string OpcaoUsr = Console.ReadLine().ToUpper();
            System.Console.WriteLine();

            return OpcaoUsr;
        }
    }
}
