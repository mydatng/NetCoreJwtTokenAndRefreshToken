﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestJwtTokenAndRefreshToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet, Authorize(Roles = "Manager")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Dat nguyen", "Nguyen Dat" };
        }
    }
}
