using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mai_website_backend.Database;
using Microsoft.AspNetCore.Mvc;

namespace mai_website_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public UserController(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
    }
}