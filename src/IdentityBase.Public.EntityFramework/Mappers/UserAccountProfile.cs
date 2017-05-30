﻿using AutoMapper;
using IdentityBase.Public.EntityFramework.Entities;

namespace IdentityBase.Public.EntityFramework.Mappers
{
    public class UserAccountProfile : Profile
    {
        public UserAccountProfile()
        {
            CreateMap<UserAccount, Models.UserAccount>(MemberList.Destination)
                .PreserveReferences();
            CreateMap<Models.UserAccount, UserAccount>(MemberList.Source)
                .PreserveReferences();

            CreateMap<ExternalAccount, Models.ExternalAccount>(MemberList.Destination)
                .PreserveReferences();
            CreateMap<Models.ExternalAccount, ExternalAccount>(MemberList.Source)
                .PreserveReferences();

            CreateMap<UserAccountClaim, Models.UserAccountClaim>(MemberList.Destination)
                .PreserveReferences();
            CreateMap<Models.UserAccountClaim, UserAccountClaim>(MemberList.Source)
                .PreserveReferences();
        }
    }
}