using Microsoft.AspNetCore.Mvc;

namespace Numbers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() {
            var user = Repository.GetData();
            return Ok(user);
        }


        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(Repository.GetData(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            Repository.Add(user);
            return Ok();
        }


        [HttpPut]
        public ActionResult Put([FromBody] User user, int id)
        {
            Repository.Edit(user,id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Repository.Delete(id);
            return Ok();
        }


    }
}
