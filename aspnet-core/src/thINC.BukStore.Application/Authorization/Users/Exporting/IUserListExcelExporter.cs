using System.Collections.Generic;
using thINC.BukStore.Authorization.Users.Dto;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}