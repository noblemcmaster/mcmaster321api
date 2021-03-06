using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models;
using api.Models.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET: api/Posts
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Post> Get()
        {
            IGetAllPosts readObject = new ReadPostData();
            return readObject.GetAllPosts();
        }

        // GET: api/Posts/5
        [EnableCors("OpenPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Post Get(int id)
        {
            IGetPosts readObject = new ReadPostData();
            return readObject.GetPost(id);
        }

        // POST: api/Posts
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Post value)
        {
            IInsertPost insertObject = new SavePost();
            insertObject.InsertPost(value);
        }

        // PUT: api/Posts/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post value)
        {
            IEditPost insertObject = new EditPost();
            insertObject.EditPosts(id, value.Text);
        }

        // DELETE: api/Posts/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IDeletePost insertObject = new DeletePost();
            insertObject.DeletePosts(id);
        }
    }
}
