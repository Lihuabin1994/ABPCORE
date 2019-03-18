using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VueCore.Configuration;
using VueCore.Web;

namespace VueCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VueCoreDbContextFactory : IDesignTimeDbContextFactory<VueCoreDbContext>
    {
        public VueCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VueCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VueCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VueCoreConsts.ConnectionStringName));

            return new VueCoreDbContext(builder.Options);
        }
    }
}
