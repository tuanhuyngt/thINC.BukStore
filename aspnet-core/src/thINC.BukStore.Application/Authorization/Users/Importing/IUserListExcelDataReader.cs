using System.Collections.Generic;
using thINC.BukStore.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace thINC.BukStore.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
