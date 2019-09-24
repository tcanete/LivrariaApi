using System.Collections.Generic;

namespace LivrariaApi.Models.Livro
{
    public class Livro
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int QuantidadePaginas { get; set; }
        public int Ano { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public Livro()
        {

        }

        public Livro(string nome, string autor, int quantidadePaginas, int ano)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.QuantidadePaginas = quantidadePaginas;
            this.Ano = ano;
        }

        public Livro(long id, string nome, string autor, int quantidadePaginas, int ano)
        {
            this.Id = id;
            this.Nome = nome;
            this.Autor = autor;
            this.QuantidadePaginas = quantidadePaginas;
            this.Ano = ano;
        }

        public Livro(long id, string nome, string autor, int quantidadePaginas, int ano, List<Comentario> comentarios)
        {
            this.Id = id;
            this.Nome = nome;
            this.Autor = autor;
            this.QuantidadePaginas = quantidadePaginas;
            this.Ano = ano;
            this.Comentarios = comentarios;
        }
    }
}