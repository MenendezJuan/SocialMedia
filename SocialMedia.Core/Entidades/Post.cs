namespace SocialMedia.Core.Entidades
{
    //Vamos a crear todas las entidades de nuestro POST
    //Vamos a manejar los diferentes POST de nuestra aplicacion
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        //Manejamos la imagen o la URL
        public string Image { get; set; }
    }
}
