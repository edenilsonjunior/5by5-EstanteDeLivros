namespace EstanteDeLivros
{
    public class Estante
    {
        public Livro[] livros;
        public int qntLivros;

        public Estante()
        {
            this.livros = new Livro[10];
            this.qntLivros = 0;
        }

        public void AdicionarLivro(Livro livro)
        {
            if (qntLivros == 10)
                Console.WriteLine("Estante cheia!!!");
            else
                this.livros[qntLivros++] = livro;
        }

        public void ImprimirLivros()
        {
            if (qntLivros == 0)
            {
                Console.WriteLine("Estante vazia!!!!");
            }
            else
            {
                for (int i = 0; i < qntLivros; i++)
                {
                    Console.WriteLine($"Livro {i + 1}: ");
                    livros[i].ImprimirLivro();
                    Console.WriteLine("=============================");
                }
            }
        }

        public void ImprimirLivroPorIndice(int indice)
        {
            if (indice < 0 || indice >= qntLivros)
                Console.WriteLine("Indice Invalido!!!!");
            else
                livros[indice].ImprimirLivro();
        }
    }
}
