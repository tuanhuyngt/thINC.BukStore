using System.Collections.Generic;
using Abp;
using thINC.BukStore.Chat.Dto;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
