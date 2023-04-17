using ClassLibrary.Data.Context;
using ClassLibrary.Data.Interfaces;
using ClassLibrary.Data.Repositories;
using ClassLibrary.Service.Interfaces;
using ClassLibrary.Service.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Service
{
    public static class Extension
    {
        public static IServiceCollection InjectMyTableServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Database
            services.AddDbContext<MyDBContext>(options => options.UseSqlServer(configuration["ConnectionStrings:DbConnection"]));

            //repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMyTableRepository, MyTableRepository>();
            

            ////Services            
            services.AddScoped<IHomeService, HomeService>();
           

            return services;
        }
    }
}
