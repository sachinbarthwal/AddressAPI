using AddressAPI.Models;

namespace AddressAPI.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;

        public AddressService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddressInfo> ProcessAddressAsync(AddressInfo addressInfo)
        {
            return await _repository.CreateAsync(addressInfo);
        }

    }
}