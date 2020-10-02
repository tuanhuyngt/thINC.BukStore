using System.Collections.Generic;
using thINC.BukStore.Authorization.Users.Importing.Dto;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
