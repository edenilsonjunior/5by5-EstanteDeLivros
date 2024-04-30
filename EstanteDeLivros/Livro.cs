namespace EstanteDeLivros
{
    public class Livro
    {
        private string titulo;
        private string[] autores;
        private DateOnly dataLancamento;
        private string editora;
        private int edicao;
        private string isbn;
        private int qntPaginas;
        private int qntAutores;

        public Livro()
        {

        }
        public Livro(string titulo, string[] autores, DateOnly dataLancamento, string editora, int edicao, string isbn, int qntPaginas)
        {
            this.titulo = titulo;
            this.autores = autores;
            this.dataLancamento = dataLancamento;
            this.editora = editora;
            this.edicao = edicao;
            this.isbn = isbn;
            this.qntPaginas = qntPaginas;
            this.qntAutores = autores.Length;
        }

        public void ImprimirAutores()
        {
            switch (this.qntAutores)
            {
                case 0:
                    Console.WriteLine("Nao existe autores cadastrados para esse livro!");
                    break;
                case 1:
                    Console.WriteLine("Autor: " + autores[0]);
                    break;
                default:
                    for (int i = 0; i < qntAutores; i++)
                    {
                        Console.WriteLine($"Autor {i + 1}: {autores[i]}");
                    }
                    break;
            }
        }

        public void ImprimirLivro()
        {
            Console.WriteLine($"Titulo: {titulo}");
            ImprimirAutores();
            Console.WriteLine($"Data de Lancamento: {dataLancamento}");
            Console.WriteLine($"Editora: {editora}");
            Console.WriteLine($"Edicao: {edicao}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Quantidade de paginas: {qntPaginas}");
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void SetDataLancamento(DateOnly date)
        {
            this.dataLancamento = date;
        }

        public void SetEditora(string editora)
        {
            this.editora = editora;
        }

        public void SetEdicao(int edicao)
        {
            this.edicao = edicao;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public void SetQntPaginas(int qntPaginas)
        {
            this.qntPaginas = qntPaginas;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string[] GetAutores()
        {
            return autores;
        }

        public DateOnly GetDataLancamento()
        {
            return dataLancamento;
        }
    
        public string GetEditora()
        {
            return editora;
        }
    
        public int GetEdicao()
        {
            return edicao;
        }
    
        public string GetIsbn()
        {
            return isbn;
        }
    
        public int GetQntPaginas()
        {
            return qntPaginas;
        }
        
        public int GetQntAutores()
        {
            return qntAutores;
        }
    }
}
