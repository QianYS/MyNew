﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyProject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Users.Dto
{
    [AutoMap(typeof(User))]
    public class UserListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public bool IsEmailConfirmed { get; set; }

        //public List<UserListRoleDto> Roles { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
