using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyWealthBridgeBorrowerApi.DTOs.BorrowerCards;
using MyWealthBridgeBorrowerApi.Services.BorrowerCardServices;

namespace MyWealthBridgeBorrowerApi.Controllers.BorrowerCards
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class borrowerCardController : ControllerBase
    {
        private readonly IBorrowerCardService borrowerCardService;
        public borrowerCardController(IBorrowerCardService borrowerCardService)
        {
            this.borrowerCardService = borrowerCardService;
        }

        [HttpGet]
        public IActionResult GetAllByUserId(int id) { 
            var result = borrowerCardService.GetAllByUserId(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(BorrowerCardDTO input) {
            var result = borrowerCardService.AddBorrowerCard(input);
            if(result == null) { return BadRequest(); }
            else {  return Ok(result); }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            borrowerCardService.DeleteBorrowerCardById(id);
            return Ok();
        }
    }
}
