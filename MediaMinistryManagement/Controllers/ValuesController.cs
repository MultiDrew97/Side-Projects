using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicAuthentication;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http;

namespace API.Controllers
{
    /*[Route("api/[controller]")]*/
    /*[ApiController]*/
    [BasicAuthentication]
    public class ValuesController : ApiController
    {
        [Route("api/[controller]")]
        public string Get()
        {
            Console.WriteLine(this.Request.Headers);
            return "Method was accessed";
        }
    }
}
