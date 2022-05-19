using Crud.Domain.Interfaces.Repository;
using Crud.Domain.Interfaces.Services;
using Crud.Domain.Services;
using Crud.Infra.Data.Dapper;
using Crud.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Infra.IoC
{
    public class SimpleInjectorContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<DataContext, DataContext>();

            services.AddTransient<ITesteRepository, TesteRepository>();

            services.AddTransient<ITesteService, TesteService>();

        }
    }
}
