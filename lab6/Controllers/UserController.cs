using DataBase;
using DataBase.Services.Users;
using Microsoft.AspNetCore.Mvc;


namespace Numbers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DbUser>> Get()//
        {
            DbUser[] data = userRepository.Get();
            return data;
        }

        [HttpGet("{id}")]   //Get [FromRoute]
        public ActionResult<DbUser> Get([FromRoute] int id)
        {
            var user = userRepository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Post([FromBody] DbUser user)//([FromBody] AddElementContract contract)
        {

            userRepository.Create(user);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update([FromBody] DbUser user)//([FromBody] AddElementContract contract)
        {
              userRepository.Update(user);
              return Ok();
          }

        [HttpDelete("{id}")]   //Get [FromRoute]
          public ActionResult Delete([FromRoute] int id)
          {
              userRepository.Delete(id);
              return Ok();
          }
    }
}