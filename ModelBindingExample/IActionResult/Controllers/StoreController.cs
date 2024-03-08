<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books")]
        public IActionResult Index()
        {
            return Content("<h1>Book Store</h1>","text/html");
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books")]
        public IActionResult Index()
        {
            return Content("<h1>Book Store</h1>","text/html");
        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
