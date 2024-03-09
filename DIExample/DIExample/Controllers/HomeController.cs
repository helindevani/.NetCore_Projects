using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;
namespace DIExample.Controllers

{
    public class HomeController : Controller
    {
        //constructer injection
       /* private readonly ICitiesService _citiesService;

        public HomeController(ICitiesService citiesService)
        {
            _citiesService=citiesService;
        }
       */
       //method injection
        [Route("/")]
        public IActionResult Index([FromServices] ICitiesService citiesService1,[FromServices]ICitiesService citiesService2,[FromServices] ICitiesService citiesService3, [FromServices] IServiceScopeFactory serviceScopeFactory)
        {

			List<string> cities =citiesService1.GetCities();
            ViewBag.Instanceid1=citiesService1.ServiceInstanceId;
			ViewBag.Instanceid2 =citiesService2.ServiceInstanceId;
			ViewBag.Instanceid3=citiesService3.ServiceInstanceId;


            using(IServiceScope scope = serviceScopeFactory.CreateScope())
            {
                ICitiesService citiesService = scope.ServiceProvider.GetService<ICitiesService>();

                ViewBag.citiservice_scope = citiesService.ServiceInstanceId;
            }
			return View(cities);
        }
    }
}
