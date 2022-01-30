using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Clase7v2.EntityFrameworkCore;
using Clase7v2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Clase7v2.Web.Tests
{
    [DependsOn(
        typeof(Clase7v2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Clase7v2WebTestModule : AbpModule
    {
        public Clase7v2WebTestModule(Clase7v2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Clase7v2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Clase7v2WebMvcModule).Assembly);
        }
    }
}