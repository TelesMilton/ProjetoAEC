using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAEC.Apresentacao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjetoAEC.Controllers
{
    [ApiController]  
    public class HomeController : ControllerBase
    {
       
        [HttpGet]
        [Route("/")]
        public HomeView Get()
        {
            return new HomeView();
        }
    }
}
