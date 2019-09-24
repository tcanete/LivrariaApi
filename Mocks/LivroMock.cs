using System;
using System.Collections.Generic;
using System.Linq;
using LivrariaApi.Models.Livro;

namespace LivrariaApi.Mocks
{
    public class LivroMock
    {
        public List<Livro> ListarLivros(){

            var livros = new List<Livro>(){
                new Livro(123456, "Nome Livro", "Autor Livro", 120, 1998, new List<Comentario>(){ new Comentario(123456, "comentario do livro")}),
                new Livro(123457, "Nome Livro 2", "Autor Livro 2", 325, 2000, new List<Comentario>())
            };

            return livros;
        }

        public List<Livro> ListarLivros(string nome, string autor, int ano){

            var livros = ListarLivros();

            return livros.Where(l => 
                (string.IsNullOrEmpty(nome) || l.Nome.ToUpper().Contains(nome.ToUpper())) &&
                (string.IsNullOrEmpty(autor) || l.Autor.ToUpper().Contains(autor.ToUpper())) &&
                (ano == 0 || l.Ano == ano)
            ).ToList();
        }
    }
}