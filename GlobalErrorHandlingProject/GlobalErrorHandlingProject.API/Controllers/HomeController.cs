﻿using GlobalErrorHandlingProject.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace GlobalErrorHandlingProject.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
       List<ProductModel> plist = new List<ProductModel>
        {
            new ProductModel{ProductId=1,ProductName="Product1"},
            new ProductModel{ProductId=2,ProductName="Product2"}
        };

        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {


            var result = plist;
            throw new Exception("Excepiton :sorry mario the princess is in another castle :)");
            return Ok(result);
        }

    }
}
