<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("book/{bookid?}/{isAuth?}")]
        public IActionResult Index(int? bookid, [FromQuery] bool isAuth, Book book)
        {

            //id should be supplied
            if (bookid == null)
            {

                return BadRequest("id is not supplied");
            }

            //id can't be empty
            // if (String.IsNullOrEmpty(Convert.ToString(Request.Query["id"])))
            //{

            //   return BadRequest("id should not be null or empty");
            //}

            // int id = Convert.ToInt32(Request.Query["id"]);

            if (bookid < 1 || bookid > 1000)
            {

                return BadRequest("id should in between 1 to 1000");
            }

            //bool isAuth = Convert.ToBoolean(Request.Query["isAuth"]);

            if (!isAuth)
            {

                return Unauthorized("user is unAuthorized");
            }

            // return RedirectToActionPermanent("Index","Store",new {});

            return Content($"Book id: {bookid} and iaAuth: {isAuth} \n book:{book}");

        }
    }
}
=======
﻿using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("book/{bookid?}/{isAuth?}")]
        public IActionResult Index(int? bookid, [FromQuery] bool isAuth, Book book)
        {

            //id should be supplied
            if (bookid == null)
            {

                return BadRequest("id is not supplied");
            }

            //id can't be empty
            // if (String.IsNullOrEmpty(Convert.ToString(Request.Query["id"])))
            //{

            //   return BadRequest("id should not be null or empty");
            //}

            // int id = Convert.ToInt32(Request.Query["id"]);

            if (bookid < 1 || bookid > 1000)
            {

                return BadRequest("id should in between 1 to 1000");
            }

            //bool isAuth = Convert.ToBoolean(Request.Query["isAuth"]);

            if (!isAuth)
            {

                return Unauthorized("user is unAuthorized");
            }

            // return RedirectToActionPermanent("Index","Store",new {});

            return Content($"Book id: {bookid} and iaAuth: {isAuth} \n book:{book}");

        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
