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
                        estante.ImprimirLivroPorIndice(int.Parse(LerString("Digite o indice do livro: ")));
                        break;
                    case 4:
                        estante.RemoverLivro(int.Parse(LerString("Digite o indice do livro: ")));
                        break;
                    case 5:
                        EditarLivro();
                        break;
                    case 6:
                        Console.WriteLine("Saindo....");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escolha invalida");
                        break;
                }

                ImprimirLinha();
                Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
                Console.ReadKey();

            } while (escolha != 6);


            int Menu()
            {
                Console.WriteLine("======Estante de livros======");

                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine("1- Adicionar Livro");
                Console.WriteLine("2- Imprimir todos os livros");
                Console.WriteLine("3- Imprimir um livro especifico");
                Console.WriteLine("4- Remover um livro especifico");
                Console.WriteLine("5- Editar um livro especifico");
                Console.WriteLine("6- Sair");
                Console.Write("R: ");
                int option = int.Parse(Console.ReadLine());

                if (option < 1 || option > 6)
                    return Menu();

                return option;
            }

            Livro CriarLivro()
            {
                Console.Clear();
                ImprimirLinha();
                Console.WriteLine("========Inserir Livro========");

                string titulo = LerString("Digite o titulo: ");
                string[] autores = LerAutores();

                DateOnly dataLancamento = DateOnly.Parse(LerString("Digite a data de lancamento: "));
                string editora = LerString("Digite a editora: ");

                int edicao = int.Parse(LerString("Digite o numero da edicao: "));
                string isbn = LerString("Digite o ISBN do livro: ");

                int qntPaginas = int.Parse(LerString("Digite o numero de paginas: "));

                return new Livro(titulo, autores, dataLancamento, editora, edicao, isbn, qntPaginas);
            }

            void EditarLivro()
            {
                int indice = int.Parse(LerString("Digite o indice do livro: "));
                Livro livroEditado = estante.GetLivroPorIndice(indice);

                // Re-leitura e gravacao dos dados do livro
                livroEditado.SetTitulo(LerString("Digite o titulo: "));
                livroEditado.SetAutores(LerAutores());

                livroEditado.SetDataLancamento(DateOnly.Parse(LerString("Digite a data de lancamento: ")));
                livroEditado.SetEditora(LerString("Digite a editora: "));

                livroEditado.SetEdicao(int.Parse(LerString("Digite o numero da edicao: ")));
                livroEditado.SetIsbn(LerString("Digite o ISBN do livro: "));
                
                livroEditado.SetQntPaginas(int.Parse(LerString("Digite o numero de paginas: ")));
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

            string[] LerAutores()
            {
                int qntAutores = int.Parse(LerString("Digite a quantidades de autores(<=3): "));

                string[] autores = new string[qntAutores];
                for (int i = 0; i < qntAutores; i++)
                {
                    autores[i] = LerString($"Digite o nome do autor {i + 1}: ");
                }
                return autores;
            }
        }
    }
}
