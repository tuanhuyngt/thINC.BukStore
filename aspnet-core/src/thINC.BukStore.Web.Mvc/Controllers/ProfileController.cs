﻿using System;
using System.Threading.Tasks;
using Abp;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AspNetZeroCore.Net;
using Abp.Auditing;
using Abp.Domain.Uow;
using Abp.Extensions;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization.Users;
using thINC.BukStore.Friendships;
using thINC.BukStore.Storage;

namespace thINC.BukStore.Web.Controllers
{
    [AbpMvcAuthorize]
    [DisableAuditing]
    public class ProfileController : ProfileControllerBase
    {
        private readonly UserManager _userManager;
        private readonly IBinaryObjectManager _binaryObjectManager;
        private readonly IFriendshipManager _friendshipManager;

        public ProfileController(
                UserManager userManager,
                IBinaryObjectManager binaryObjectManager,
                ITempFileCacheManager tempFileCacheManager,
                IFriendshipManager friendshipManager
            ) : base(tempFileCacheManager)
        {
            _userManager = userManager;
            _binaryObjectManager = binaryObjectManager;
            _friendshipManager = friendshipManager;
        }

        public async Task<FileResult> GetProfilePicture()
        {
            var user = await _userManager.GetUserByIdAsync(AbpSession.GetUserId());
            if (user.ProfilePictureId == null)
            {
                return GetDefaultProfilePictureInternal();
            }

            return await GetProfilePictureById(user.ProfilePictureId.Value);
        }

        public async Task<FileResult> GetProfilePictureById(string id = "")
        {
            if (id.IsNullOrEmpty())
            {
                return GetDefaultProfilePictureInternal();
            }

            return await GetProfilePictureById(Guid.Parse(id));
        }

        [UnitOfWork]
        public virtual async Task<FileResult> GetFriendProfilePictureById(long userId, int? tenantId, string id = "")
        {
            if (id.IsNullOrEmpty() ||
                await _friendshipManager.GetFriendshipOrNullAsync(AbpSession.ToUserIdentifier(), new UserIdentifier(tenantId, userId)) == null)
            {
                return GetDefaultProfilePictureInternal();
            }

            using (CurrentUnitOfWork.SetTenantId(tenantId))
            {
                return await GetProfilePictureById(Guid.Parse(id));
            }
        }

        private async Task<FileResult> GetProfilePictureById(Guid profilePictureId)
        {
            var file = await _binaryObjectManager.GetOrNullAsync(profilePictureId);
            if (file == null)
            {
                return GetDefaultProfilePictureInternal();
            }

            return File(file.Bytes, MimeTypeNames.ImageJpeg);
        }
    }
}