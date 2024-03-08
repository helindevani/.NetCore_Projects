<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookStore")]
        public IActionResult Index()
        {
            //book id should be applied
            if (!Request.Query.ContainsKey("bookid"))
            {
                Response.StatusCode = 400;
                return Content("Book Id Should Be Not Provided");
            }

            //book id cant't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                Response.StatusCode = 400;
                return Content("Book Id Should Not Be Empty OR Null");
            }

            //book id between 1 to 1000
            int bookid = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);

            if (bookid <= 0)
            {
                Response.StatusCode = 400;
                return Content("book id should not be less than or equal to 0");
            }
            if (bookid > 1000)
            {
                //Response.StatusCode = 400;
                return BadRequest("book id not greater than 1000");
            }

            if (Convert.ToBoolean(Request.Query["isLoggedin"]) == false)
            {
                //Response.StatusCode = 401;
                return Unauthorized("User Must Be Not Authenticate");
            }

            //return File("/react.pdf", "application/pdf");
            //return new RedirectToActionResult("Books","Store",new {});//for 302 tempory redirect
            return new RedirectToActionResult("Index", "Store", new { }, permanent: true);//for 301 permanetly redirect
            //return RedirectToAction()
            //return RedirectToActionPermanent()
            //return LocalRedirect("store/books/");
            //return Redirect("store/books);
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookStore")]
        public IActionResult Index()
        {
            //book id should be applied
            if (!Request.Query.ContainsKey("bookid"))
            {
                Response.StatusCode = 400;
                return Content("Book Id Should Be Not Provided");
            }

            //book id cant't be empty
            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                Response.StatusCode = 400;
                return Content("Book Id Should Not Be Empty OR Null");
            }

            //book id between 1 to 1000
            int bookid = Convert.ToInt16(ControllerContext.HttpContext.Request.Query["bookid"]);

            if (bookid <= 0)
            {
                Response.StatusCode = 400;
                return Content("book id should not be less than or equal to 0");
            }
            if (bookid > 1000)
            {
                //Response.StatusCode = 400;
                return BadRequest("book id not greater than 1000");
            }

            if (Convert.ToBoolean(Request.Query["isLoggedin"]) == false)
            {
                //Response.StatusCode = 401;
                return Unauthorized("User Must Be Not Authenticate");
            }

            //return File("/react.pdf", "application/pdf");
            //return new RedirectToActionResult("Books","Store",new {});//for 302 tempory redirect
            return new RedirectToActionResult("Index", "Store", new { }, permanent: true);//for 301 permanetly redirect
            //return RedirectToAction()
            //return RedirectToActionPermanent()
            //return LocalRedirect("store/books/");
            //return Redirect("store/books);
        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
