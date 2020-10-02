using System.Collections.Generic;
using thINC.BukStore.DynamicEntityParameters.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.DynamicParameters
{
    public class CreateOrEditDynamicParameterViewModel
    {
        public DynamicParameterDto DynamicParameterDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
