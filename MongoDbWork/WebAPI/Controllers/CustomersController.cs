using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Services.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Customer customer)
        {
            try
            {
                await _customerService.AddAsync(customer);
                return Ok("Müşteri Kaydedildi");
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var model = await _customerService.GetItemsByConditionAsync(k => true);
                return Ok(model);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

    }
}