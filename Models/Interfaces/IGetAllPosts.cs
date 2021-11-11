using System.Collections.Generic;

namespace api.Models.Interfaces
{
    public interface IGetAllPosts
    {
         List<Post> GetAllPosts();
    }
}