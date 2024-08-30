using AddressAPI.Config;
using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using Raven.Client.Exceptions.Database;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;

public class RavenDbContext
{
    private readonly IDocumentStore _store;

    public RavenDbContext(IOptions<RavenDbSettings> settings)
    {
        _store = new DocumentStore
        {
            Urls = settings.Value.Urls,
            Database = settings.Value.DatabaseName
        };

        _store.Initialize();

        EnsureDatabaseExists(settings.Value.DatabaseName);
    }

    public IDocumentStore Store => _store;

    private void EnsureDatabaseExists(string database)
    {
        try
        {
            _store.Maintenance.Server.Send(new GetDatabaseRecordOperation(database));
        }
        catch (DatabaseDoesNotExistException)
        {
            _store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(database)));
        }
    }
}