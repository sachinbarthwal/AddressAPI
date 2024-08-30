using AddressAPI.Models;

namespace AddressAPI.Services
{
    public interface IAddressService
    {
        Task<AddressInfo> ProcessAddressAsync(AddressInfo addressInfo);
    }
}