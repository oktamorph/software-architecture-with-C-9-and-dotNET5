using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WWTravelClubDB
{
    public class LibraryDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        private const string endpoint = "https://oktamorph.documents.azure.com:443/";
        private const string key = "iUOGiBNEAX2dH0y5gKP1Nv3BDrrrOVtPzFQ4RiCbjRMPnySh6U64VauHQH9M6tTl3LgxOMBWVBthX6qEt65wqA==";
        private const string databaseName = "packagesdb";

        public MainDbContext CreateDbContext(params string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();
            builder.UseCosmos(endpoint, key, databaseName);

            return new MainDbContext(builder.Options);
        }
    }

}
