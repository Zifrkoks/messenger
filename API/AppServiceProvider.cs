using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Repositories;

namespace API
{
    public static class AppServiceProvider
    {
        public static void AddRepositories(this IServiceCollection services){
            services.AddTransient<GroupRepository>();
            services.AddTransient<RoleRepository>();
            services.AddTransient<MessageRepository>();
            services.AddTransient<UserRepository>();

        }
    }
}