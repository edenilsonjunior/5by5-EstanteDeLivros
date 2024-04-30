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

        public void AddLivro(Livro livro)
        {
            if (qntLivros == 10)
                Console.WriteLine("Estante cheia!!!");
            else
                this.livros[qntLivros++] = livro;
        }

        public void RemoverLivro(int indice)
        {
            if (qntLivros == 0)
            {
                Console.WriteLine("Estante vazia!!!!");
                return;
            }

            if (indice < 0 || indice >= qntLivros)
            {
                Console.WriteLine("Indice Invalido!");
            }
            else
            {
                int i = indice;
                while (i < qntLivros - 1)
                {
                    livros[i] = livros[i + 1];
                    i++;
                }
                livros[qntLivros - 1] = null;
                qntLivros--;
                Console.WriteLine("Livro removido com sucesso!");
            }
        }

        public Livro GetLivroPorIndice(int indice)
        {
            if (qntLivros == 0)
            {
                Console.WriteLine("Estante vazia!!!!");
            }

            if (indice < 0 || indice >= qntLivros)
            {
                Console.WriteLine("Indice Invalido!");
            }
            else
            {
                return livros[indice];
            }
            return null;
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
