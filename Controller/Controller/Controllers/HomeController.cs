<<<<<<< HEAD
﻿using ControllerExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult() {Content="hello this is",ContentType="text/plain"};
            return Content("<h1>Hello This is Home Page</h1>", "text/html");
        }
        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person() { Id = Guid.NewGuid(), Firstname = "Helin", Lastname = "Devani", Age = 18 };
            //return new JsonResult(person);
            return Json(person);
        }
        [Route("contact-us/{mobaileno:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello this is Contact controller";
        }

        [Route("download")]
        public VirtualFileResult FileDownload()
        {
            //return new VirtualFileResult("/React.pdf","application/pdf");
            return File("/react.pdf", "application/pdf");
        }

        [Route("download2")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult(@"C:/.NetCore_Projects/React.pdf", "application/pdf");
            return PhysicalFile(@"C:\.NetCore_Projects\Controller\react.pdf", "application/pdf");
        }

        [Route("download3")]
        public FileContentResult FileDownload3()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\.NetCore_Projects\Controller\react.pdf");
            //return new FileContentResult(bytes, "application/pdf");
            return File(bytes, "application/pdf");
        }
    }
}
=======
﻿ using Microsoft.AspNetCore.Mvc;
using Controller.Models;
namespace Controller.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("Home")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult() {Content="hello this is",ContentType="text/plain"};
            return Content("<h1>Hello This is Home Page</h1>","text/html");
        }
        [Route("person")]
        public JsonResult Person()
        {
            Person person= new Person() { Id= Guid.NewGuid(), Firstname = "Helin", Lastname="Devani",Age=18};
            //return new JsonResult(person);
            return Json(person);
        }
        [Route("contact-us/{mobaileno:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello this is Contact controller";
        }

        [Route("download")]
        public VirtualFileResult FileDownload()
        {
            //return new VirtualFileResult("/React.pdf","application/pdf");
            return File("/react.pdf","application/pdf");
        }

        [Route("download2")]
        public PhysicalFileResult FileDownload2()
        {
            //return new PhysicalFileResult(@"C:/.NetCore_Projects/React.pdf", "application/pdf");
            return PhysicalFile(@"C:\.NetCore_Projects\Controller\react.pdf","application/pdf");
        }

        [Route("download3")]
        public FileContentResult FileDownload3()
        {
            byte[] bytes= System.IO.File.ReadAllBytes(@"C:\.NetCore_Projects\Controller\react.pdf");
            //return new FileContentResult(bytes, "application/pdf");
            return File(bytes,"application/pdf");
        }


    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
