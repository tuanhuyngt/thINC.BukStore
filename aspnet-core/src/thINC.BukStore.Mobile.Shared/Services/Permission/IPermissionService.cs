﻿namespace thINC.BukStore.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}