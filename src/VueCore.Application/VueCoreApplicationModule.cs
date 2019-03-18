using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueCore.Authorization;

namespace VueCore
{
    [DependsOn(
        typeof(VueCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VueCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VueCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VueCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
