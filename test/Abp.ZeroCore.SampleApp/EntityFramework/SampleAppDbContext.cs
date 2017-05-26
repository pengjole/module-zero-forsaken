﻿using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Abp.ZeroCore.SampleApp.Core;
using Microsoft.EntityFrameworkCore;

namespace Abp.ZeroCore.SampleApp.EntityFramework
{
    public class SampleAppDbContext : AbpZeroDbContext<Tenant, Role, User, SampleAppDbContext>, IAbpPersistedGrantDbContext
    {
        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options) 
            : base(options)
        {
        }
    }
}
