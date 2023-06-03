using Microsoft.AspNetCore.Mvc;

namespace Numbers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var user = userRepository.GetData();
            return Ok(user);
        }


        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(userRepository.GetData(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            userRepository.Add(user);
            return Ok();
        }


        [HttpPut]
        public ActionResult Put([FromBody] User user, int id)
        {
            userRepository.Edit(user, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            userRepository.Delete(id);
            return Ok();
        }


    }
}
