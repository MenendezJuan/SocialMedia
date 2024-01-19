using SocialMedia.Core.Entidades;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
        //Metodo asincrono que devuelve un listado de Posts
        Task<IEnumerable<Post>> GetPosts();
    }
}
