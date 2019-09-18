using System;
using System.Collections.Generic;
using LivrariaApi.Models;

namespace LivrariaApi.Mocks
{
    public class LivroMock
    {
        public List<Livro> ListarLivros(){

            var livros = new List<Livro>(){
                new Livro(DateTime.Now.Ticks, "Nome Livro", "Autor Livro", 120, 1998),
                new Livro(DateTime.Now.Ticks, "Nome Livro 2", "Autor Livro 2", 325, 2000)
            };

            return livros;
        }
    }
}