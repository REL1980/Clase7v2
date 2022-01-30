using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Clase7v2.Configuration;
using Clase7v2.Web;

namespace Clase7v2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Clase7v2DbContextFactory : IDesignTimeDbContextFactory<Clase7v2DbContext>
    {
        public Clase7v2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Clase7v2DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Clase7v2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Clase7v2Consts.ConnectionStringName));

            return new Clase7v2DbContext(builder.Options);
        }
    }
}
