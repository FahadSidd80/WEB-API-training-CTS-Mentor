using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using di_cors_api_demo.Models;
namespace di_cors_api_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //ProductList pObj = new ProductList();
        //this is a crime

        ProductList _pObj;

        public ProductsController(ProductList _pObjREF)
        {
            _pObj = _pObjREF;
        }

        [HttpGet]
        [Route("/plist")]
        public IActionResult GetProducts()
        {
            return Ok(_pObj.GetProducts());
        }

    }
}
