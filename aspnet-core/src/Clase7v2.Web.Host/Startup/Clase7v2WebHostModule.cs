using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7v2.Configuration;

namespace Clase7v2.Web.Host.Startup
{
    [DependsOn(
       typeof(Clase7v2WebCoreModule))]
    public class Clase7v2WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Clase7v2WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Clase7v2WebHostModule).GetAssembly());
        }
    }
}
