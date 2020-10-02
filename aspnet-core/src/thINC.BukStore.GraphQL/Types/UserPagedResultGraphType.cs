using Abp.Application.Services.Dto;
using GraphQL.Types;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Types
{
    public class UserPagedResultGraphType : ObjectGraphType<PagedResultDto<UserDto>>
    {
        public UserPagedResultGraphType()
        {
            Field(x => x.TotalCount);
            Field(x => x.Items, type: typeof(ListGraphType<UserType>));
        }
    }
}