using AddressAPI.Models;
using Raven.Client.Documents;

namespace AddressAPI.Services
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IDocumentStore _store;

        public AddressRepository(RavenDbContext context)
        {
            _store = context.Store;
        }

        public async Task<AddressInfo> CreateAsync(AddressInfo addressInfo)
        {
            using (var session = _store.OpenAsyncSession())
            {
                await session.StoreAsync(addressInfo);
                await session.SaveChangesAsync();
                return addressInfo;
            }
        }
    }
}
