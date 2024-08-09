using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CRMManagerContext>(options => options.UseSqlServer("data source=CNTT1\\SQLEXPRESS;initial catalog=CRMManager;integrated security=true;MultipleActiveResultSets=true;encrypt=false"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
