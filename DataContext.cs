using Microsoft.EntityFrameworkCore;
using sillypub.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sillypub{
    public class DataContext: ApiAuthorizationDbContext<User> {
        public DataContext(DbContextOptions<DataContext> options, IOptions<OperationalStoreOptions> operationalStoreOptions): 
        base(options, operationalStoreOptions) {

        }
    }  
}