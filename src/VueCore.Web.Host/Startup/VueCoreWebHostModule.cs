using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueCore.Configuration;

namespace VueCore.Web.Host.Startup
{
    [DependsOn(
       typeof(VueCoreWebCoreModule))]
    public class VueCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VueCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueCoreWebHostModule).GetAssembly());
        }
    }
}
