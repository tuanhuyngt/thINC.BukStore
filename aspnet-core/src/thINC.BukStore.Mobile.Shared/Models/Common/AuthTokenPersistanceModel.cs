﻿using System;
using Abp.AutoMapper;
using thINC.BukStore.Sessions.Dto;

namespace thINC.BukStore.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}