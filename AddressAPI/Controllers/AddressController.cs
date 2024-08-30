using Microsoft.AspNetCore.Mvc;
using AddressAPI.Models;
using AddressAPI.Services;

namespace AddressAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        public async Task<ActionResult<AddressInfo>> Post([FromBody] AddressInfo addressInfo)
        {
            var result = await _addressService.ProcessAddressAsync(addressInfo);
            return Ok(result);
        }

    }
}