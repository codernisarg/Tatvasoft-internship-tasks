using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class bookController : Controller
    {
        private readonly Bookservices bookservices;
        
        public bookController(Bookservices book ) { 
            this.bookservices = book;
        }

        
        [HttpPost]
        [Route("Add")]
        public ActionResult Addbook(book book)
        {
            //Bookservices = new Bookservices();
            this.bookservices.Addbook(book);
            return Ok("Book added ! ");
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult getall()
        {
            return Ok(this.bookservices.getall());
        }

        [HttpGet]
        [Route("getbyid")]
        public ActionResult getbyid(int id)
        {
            var res = this.bookservices.getbyid(id);

            if(res != null) {
                return Ok(res);
            }
            return NotFound("Book not found ! ");
        }

    }
}
