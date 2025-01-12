using Common.Model.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace plugin.Registrator;

public class PluginRegistrator : IPluginRegistrator
{
    public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration)
    {
        //TODO: Add your services here
        return services;
    }

    public void UseApplication(IServiceProvider serviceProvider)
    {
        //TODO: Add your application logic here
    }
}