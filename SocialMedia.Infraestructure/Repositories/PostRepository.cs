using SocialMedia.Core.Entidades;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Infraestructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        //Enumerable con post, para retornar el listado
        //public IEnumerable<Post> GetPosts()
        //{
        //    //Le seteamos un rango de 1 a 10
        //    var posts = Enumerable.Range(1, 10).Select(x => new Post
        //    {
        //        PostId = x,
        //        Description = $"Desciption: {x}",
        //        Date = DateTime.Now,
        //        Image = "https://misapis.com/{x}",
        //        UserId = x * 2
        //    });
        //    return posts;
        //}

        //Listado de publicaciones asincrono
        public async Task<IEnumerable<Post>> GetPosts()
        {
            //Le seteamos un rango de 1 a 10
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Desciption: {x}",
                Date = DateTime.Now,
                Image = "https://misapis.com/{x}",
                UserId = x * 2
            });

            await Task.Delay(10);


            return posts;
        }
    }
}
