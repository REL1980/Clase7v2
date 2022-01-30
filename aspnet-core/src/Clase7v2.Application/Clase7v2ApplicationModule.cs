using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7v2.Authorization;

namespace Clase7v2
{
    [DependsOn(
        typeof(Clase7v2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Clase7v2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Clase7v2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Clase7v2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
