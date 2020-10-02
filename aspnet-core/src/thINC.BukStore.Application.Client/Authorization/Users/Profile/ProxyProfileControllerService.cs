using System;
using System.Threading.Tasks;
using Flurl.Http.Content;
using thINC.BukStore.Authorization.Users.Profile.Dto;

namespace thINC.BukStore.Authorization.Users.Profile
{
    public class ProxyProfileControllerService : ProxyControllerBase
    {
        public async Task<UploadProfilePictureOutput> UploadProfilePicture(Action<CapturedMultipartContent> buildContent)
        {
            return await ApiClient
                .PostMultipartAsync<UploadProfilePictureOutput>(GetEndpoint(nameof(UploadProfilePicture)), buildContent);
        }
    }
}