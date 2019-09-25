using System;
using System.Collections.Generic;
using LivrariaApi.Models.Pedidos;

namespace LivrariaApi.Mocks
{
    public class PedidosMock
    {
        public List<Pedido> ListarPedidosUsuario(long id){

            return new List<Pedido>(){
                new Pedido{
                    Id = 123,
                    Status = "Entregue",
                    UsuarioId = id,
                    Livros = new List<Models.Livros.Livro>(){
                        new Models.Livros.Livro(){
                            Ano = 1234,
                            Autor = "José",
                            Id = 1111,
                            Nome = "Nome do Livro",
                            QuantidadePaginas = 100,
                            Comentarios = new List<Models.Livros.Comentario>()
                        }
                    },
                    DataPedido = DateTime.Now
                },
                new Pedido{
                    Id = 124,
                    Status = "Processando",
                    UsuarioId = id,
                    Livros = new List<Models.Livros.Livro>(){
                        new Models.Livros.Livro(){
                            Ano = 1443,
                            Autor = "Carla",
                            Id = 12344,
                            Nome = "Nome do Livro 2",
                            QuantidadePaginas = 230,
                            Comentarios = new List<Models.Livros.Comentario>(){
                                new Models.Livros.Comentario{
                                    Id = 3333,
                                    IdLivro = 12344,
                                    TextoComentario = "muito bom"
                                }
                            }
                        }
                    },
                    DataPedido = DateTime.Now
                }
            };
        }
    }
}