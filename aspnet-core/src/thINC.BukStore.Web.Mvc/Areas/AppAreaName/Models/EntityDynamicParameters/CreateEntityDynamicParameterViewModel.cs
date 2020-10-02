using System.Collections.Generic;
using thINC.BukStore.DynamicEntityParameters.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.EntityDynamicParameters
{
    public class CreateEntityDynamicParameterViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicParameterDto> DynamicParameters { get; set; }
    }
}
