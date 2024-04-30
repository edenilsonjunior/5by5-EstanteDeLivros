namespace EstanteDeLivros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new();
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
                        estante.AddLivro(CriarLivro());
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
                Console.WriteLine("========Inserir Livro========");

                string titulo, editora, isbn;
                DateOnly dataLancamento;
                string[] autores;
                int qntAutores, edicao, qntPaginas;


                titulo = LerString("Digite o titulo: ");
                qntAutores = int.Parse(LerString("Digite a quantidades de autores(<=3): "));

                autores = new string[qntAutores];
                for (int i = 0; i < qntAutores; i++)
                {
                    autores[i] = LerString($"Digite o nome do autor {i + 1}: ");
                }

                dataLancamento = DateOnly.Parse(LerString("Digite a data de lancamento: "));
                editora = LerString("Digite a editora: ");
                edicao = int.Parse(LerString("Digite o numero da edicao: "));

                isbn = LerString("Digite o ISBN do livro: ");
                qntPaginas = int.Parse(LerString("Digite o numero de paginas: "));

                return new Livro(titulo, autores, dataLancamento, editora, edicao, isbn, qntPaginas);
            }

            string LerString(string titulo)
            {
                Console.Write(titulo);
                return Console.ReadLine();
            }


            void ImprimirLinha()
            {
                Console.WriteLine("=============================");
            }
        }
    }
}
