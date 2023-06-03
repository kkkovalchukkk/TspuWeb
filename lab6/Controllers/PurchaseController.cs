using DataBase;
using DataBase.Services.Users;
using lab6.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab6.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController : ControllerBase
    {
        private readonly IUserPurchaseRepository purchaseRepository;

        public PurchaseController(IUserPurchaseRepository purchaseRepository)
        {
            this.purchaseRepository = purchaseRepository;
        }

        // GET api/values
       
        // GET api/values/5
        [HttpGet("{id}")]   //Get [FromRoute]
        public ActionResult<UserPurchase> Get([FromRoute] int id)
        {
            var user = purchaseRepository.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        [HttpPost]
        public ActionResult Post([FromBody] UserPurchase userpurchase)//([FromBody] AddElementContract contract)
        {

            purchaseRepository.Create(userpurchase);
            return Ok();
        }
    }
}