using AddressAPI.Models;

namespace AddressAPI.Services
{
    public interface IAddressRepository
    {
        Task<AddressInfo> CreateAsync(AddressInfo addressInfo);
    }
}
