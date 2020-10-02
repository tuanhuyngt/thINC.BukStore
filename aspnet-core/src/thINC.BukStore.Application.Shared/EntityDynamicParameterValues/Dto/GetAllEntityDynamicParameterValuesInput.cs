using System.ComponentModel.DataAnnotations;

namespace thINC.BukStore.EntityDynamicParameterValues.Dto
{
    public class GetAllEntityDynamicParameterValuesInput
    {
        [Required]
        public string EntityFullName { get; set; }

        [Required]
        public string EntityId { get; set; }
    }
}
