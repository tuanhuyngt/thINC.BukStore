using System.Collections.Generic;
using thINC.BukStore.Auditing.Dto;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
