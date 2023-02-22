using Microsoft.AspNetCore.Mvc;
using Retail.Models.ViewModels;
using Retail.Services.Implementation;
using Retail.Services.Interface;
using Retail.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
            private readonly IProductServices _iProductServices;
        private readonly ILogger _logger;
            public ProductController(IProductServices productServices)
            {
                _iProductServices = productServices;
               
            }
        /*
            // GET: api/<ProductController>
            [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */
        // GET api/<ProductController>/5
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
                return Ok(_iProductServices.GetProductDetails());
           
            
        }
        
        [HttpGet("GetProduct/{Identity}")]
        public IActionResult Get(Guid Identity)
        {
           try { 
                var productList = _iProductServices.GetProductDetailsById(Identity);
                Console.WriteLine(productList.Qty);
                //return OkObjectResult( { 'data': productList, 'status': "success"});
                return Ok(productList);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("AddProduct")]
        public void Post(ProductViewModel product)
        {
            _iProductServices.AddProduct(product);
        }
        // PUT api/<ValuesController>/5
        [HttpPut("PutProducts/{Identity}")]
        public void Put(Guid Identity, ProductViewModel product)
        {
            _iProductServices.PutProduct(Identity, product);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteProduct/{Identity}")]
        public void Delete(Guid Identity)
        {
            _iProductServices.DeleteProduct(Identity);
        }
    }
}
