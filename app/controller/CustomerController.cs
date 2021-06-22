using System.Threading.Tasks;
using CustomerManagement.app.services;
using CustomerManagement.app.services.models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.app.controller
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService customerService;
        public CustomerController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string name)
        {
            var response = await customerService.GetAll();
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] CustomerDTO request)
        {
            await customerService.Save(request);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CustomerDTO request)
        {
            await customerService.Update(request);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            await customerService.Delete(id);
            return Ok();
        }
    }
}