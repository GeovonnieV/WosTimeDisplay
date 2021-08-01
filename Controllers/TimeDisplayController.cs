using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WosTimeDisplay.Controllers
    {

        public class TimeDisplayController : Controller
            {
                [HttpGet("")]
                public ViewResult Index()
                    {
                        return View();
                    }
            }

    }
