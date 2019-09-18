namespace LivrariaApi.Models {
    public class Livro
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Autor { get; set; }
        public int QuantidadePaginas {get; set;}
        public int Ano { get; set; }

        public Livro(string nome, string autor, int quantidadePaginas, int ano)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.QuantidadePaginas = quantidadePaginas;
            this.Ano = ano;
        }
    }
}