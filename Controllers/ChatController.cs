using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace quickchat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        DataContext db = new DataContext();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Chat>> Get()
        {
            return db.Chats.OrderBy(c=>c.SentTime).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Chat>> Get(int id)
        {
            return db.Chats.Where(c=>c.Id>id).OrderBy(c=>c.SentTime).ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post(string content, string username)
        {
            Chat c = new Chat();
            c.Content=content;
            c.Username=username;
            c.SentTime=DateTime.Now;
            db.Chats.Add(c);
            db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
