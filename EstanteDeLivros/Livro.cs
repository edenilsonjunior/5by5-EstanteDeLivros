using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Livro
    {
        public string titulo;
        public string[] autores;
        public DateOnly dataLancamento;
        public string editora;
        public int edicao;
        public string isbn;
        public int qntPaginas;
        public int qntAutores;

        public Livro()
        {
            autores = new string[3];
            qntAutores = 0;
        }

        public void DefinirTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void AdicionarAutor(string autor)
        {
            if (qntAutores == 3)
                Console.WriteLine("Maximo de autores atingido!");
            else
                autores[qntAutores++] = autor;
        }

        public void DefinirDataLancamento(DateOnly date)
        {
            this.dataLancamento = date;
        }

        public void DefinirEditora(string editora)
        {
            this.editora = editora;
        }

        public void DefinirEdicao(int edicao)
        {
            this.edicao = edicao;
        }

        public void DefinirIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public void DefinirQntPaginas(int qntPaginas)
        {
            this.qntPaginas = qntPaginas;
        }

        public void ImprimirAutores()
        {
            if (this.qntAutores == 1)
            {
                Console.WriteLine("Nao existe autores cadastrados para esse livro!");
            }
            else if (this.qntAutores == 1)
            {
                Console.WriteLine("Autor: " + autores[0]);
            }
            else
            {
                for (int i = 0; i < qntAutores; i++)
                {
                    Console.WriteLine($"Autor {i + 1}: {autores[i]}");
                }
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
    }
}
