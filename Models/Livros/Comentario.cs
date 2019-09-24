namespace LivrariaApi.Models.Livros
{
    public class Comentario
    {
        public long Id { get; set; }
        public string TextoComentario { get; set; }
        public long IdLivro { get; set; }

        public Comentario()
        {
            
        }

        public Comentario(long idLivro, string textoComentario)
        {
            this.IdLivro = idLivro;
            this.TextoComentario = textoComentario;
        }
    }
}