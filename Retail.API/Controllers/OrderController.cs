using Microsoft.AspNetCore.Mvc;
using Retail.Models.ViewModels;
using Retail.Repository.Interface;
using Retail.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
       private readonly IOrderServices _iOrderServices;
        public OrderController(IOrderServices iOrderServices)
        {
            _iOrderServices = iOrderServices;
        }
        //GET 
        [HttpGet("GetOrderDetails")]
        public IActionResult Get()
        {
            return Ok(_iOrderServices.GetOrders());
        }
        // GET BY ID
        [HttpGet("GetOrderDetailsById/{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_iOrderServices.GetOrders(id));
        }
       
        // POST 
        [HttpPost("OrderProduct")]
        public void Post(OrderViewModel Order)
        {
            _iOrderServices.PostOrder(Order);
        }

        
       // PUT api/<OrderController>/5
       [HttpPut("EditOrderDetails/{id}")]
       public void Put(Guid id,OrderViewModel Order)
       {
            _iOrderServices.PutOrder(id,Order);
       }
        
       // DELETE api/<OrderController>/5
       [HttpDelete("DeleteOrder/{id}")]
       public void Delete(Guid id)
       {
            _iOrderServices.DeleteOrder(id);
       }
    }
}
