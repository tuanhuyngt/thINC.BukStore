using Abp.AutoMapper;
using thINC.BukStore.Organizations.Dto;

namespace thINC.BukStore.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}