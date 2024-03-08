<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;
using ModelValidationsExample.CustomModelBinders;

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        // [Bind(nameof(person.PersonName),nameof(person.Price))]
        //[FromBody] that is provide parse data into other format
        //[ModelBinder(BinderType = typeof(PersonModelBinder))]
        public IActionResult Index([FromBody] Person person, [FromHeader(Name = "User-Agent")] string UserAgent)
        {
            if(!ModelState.IsValid)
            {
                string errors = string.Join("\n", ModelState.Values.SelectMany(Value => Value.Errors).Select(err => err.ErrorMessage));
                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;
using ModelValidationsExample.CustomModelBinders;

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        // [Bind(nameof(person.PersonName),nameof(person.Price))]
        //[FromBody] that is provide parse data into other format
        //[ModelBinder(BinderType = typeof(PersonModelBinder))]
        public IActionResult Index([FromBody] Person person, [FromHeader(Name = "User-Agent")] string UserAgent)
        {
            if(!ModelState.IsValid)
            {
                string errors = string.Join("\n", ModelState.Values.SelectMany(Value => Value.Errors).Select(err => err.ErrorMessage));
                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
