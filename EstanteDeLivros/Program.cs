namespace EstanteDeLivros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante();
            int escolha;

            do
            {
                Console.Clear();
                Console.WriteLine("=====Estante de livros=====");
                escolha = Menu();
                ImprimirLinha();

                switch (escolha)
                {
                    case 1:
                        estante.AdicionarLivro(CriarLivro());
                        break;
                    case 2:
                        estante.ImprimirLivros();
                        break;
                    case 3:
                        Console.Write("Digite o indice do livro: ");
                        estante.ImprimirLivroPorIndice(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Saindo....");
                        break;
                    default:
                        Console.WriteLine("Escolha invalida");
                        break;
                }

                if (escolha != 4)
                {
                    Console.Write("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (escolha != 4);

            /*-----Funcoes-----*/

            /*
             * Menu que le a entrada do usuario e devolve a opcao
             */
            int Menu()
            {
                int option;
                do
                {
                    ImprimirLinha();
                    Console.WriteLine("Escolha uma opcao");
                    Console.WriteLine("1- Adicionar Livro");
                    Console.WriteLine("2- Imprimir todos os livros");
                    Console.WriteLine("3- Imprimir um livro especifico");
                    Console.WriteLine("4- Sair");
                    Console.Write("R: ");
                    option = int.Parse(Console.ReadLine());

                } while (option < 0 || option > 4);

                return option;
            }

            Livro CriarLivro()
            {
                Livro livro = new Livro();

                Console.WriteLine("========Inserir Livro========");

                Console.Write("Digite o titulo: ");
                livro.DefinirTitulo(Console.ReadLine());

                Console.Write("Digite a quantidades de autores(<=3): ");
                int qntAutores = int.Parse(Console.ReadLine());

                for (int i = 0; i < qntAutores; i++)
                {
                    Console.Write($"Digite o nome do autor {i + 1}: ");
                    livro.AdicionarAutor(Console.ReadLine());
                }

                Console.Write("Digite a data de lancamento: ");
                livro.DefinirDataLancamento(DateOnly.Parse(Console.ReadLine()));

                Console.Write("Digite a editora: ");
                livro.DefinirEditora(Console.ReadLine());

                Console.Write("Digite o numero da edicao: ");
                livro.DefinirEdicao(int.Parse(Console.ReadLine()));

                Console.Write("Digite o ISBN do livro: ");
                livro.DefinirIsbn(Console.ReadLine());

                Console.Write("Digite o numero de paginas: ");
                livro.DefinirQntPaginas(int.Parse(Console.ReadLine()));

                return livro;
            }

            void ImprimirLinha()
            {
                Console.WriteLine("=============================");
            }
        }
    }
}
