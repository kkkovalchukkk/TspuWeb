using Microsoft.AspNetCore.Mvc;



namespace Numbers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
       public ActionResult Get([FromQuery] int count)
        {
            var random=new Random();
            var array = new int[count];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next();
            }
            return Ok(array);
        }
        
    }
}