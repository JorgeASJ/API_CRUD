using Crud.Infra.Data.Dapper;
using Microsoft.Extensions.DependencyInjection;

namespace Crud.Infra.IoC
{
    public class SimpleInjectorContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<DataContext, DataContext>();

        }
    }
}
