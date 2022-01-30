using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Clase7v2.MultiTenancy;

namespace Clase7v2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
