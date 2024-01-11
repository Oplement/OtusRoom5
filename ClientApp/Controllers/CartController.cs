﻿using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;

namespace ClientApp.Controllers
{
    public class CartController : Controller
    {
        RequestService _requestService;
        public CartController(RequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpGet("Cart")]
        public IActionResult Index()
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            ResponseModel response = _requestService.SendGet(service, $"api/orders/cart?userid={HttpContext.Items["userid"]}", this.HttpContext);

            var cartOrder = new List<OrderProduct>();

            if (response.success)
            {
                cartOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderProduct>>(response.result.ToString());
            }

            return View(cartOrder);
        }
        [HttpPost("Cart")]
        public IActionResult Put([FromForm] Guid productid)
        {

            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            ResponseModel response = _requestService.SendPost(service, $"api/orders/cart", new { userid = HttpContext.Items["userid"], productid = productid} , this.HttpContext);

            var cartOrder = new List<Product>();

            if (response.success)
            {
                cartOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response.result.ToString());
            }

            return Redirect("/mainpage");
        }
    }
}
