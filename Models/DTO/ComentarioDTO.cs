using LivrariaApi.Models.Livros;

namespace LivrariaApi.Models.DTO
{
    public class ComentarioDTO
    {
        public long IdLivro { get; set; }
        public string Comentario { get; set; }
    }
}