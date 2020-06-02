using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Microservice.RabbitMQMessageBrokerExtension.Configuration
{
    public static class MessageBrokerServiceCollectionExtensions
    {
        public static IServiceCollection AddRabbitMqMessageBroker(this IServiceCollection container, string )
        {
            var config = new ConfigurationBuilder();
            config.Add()
                //.SetBasePath(Directory.GetCurrentDirectory())
                //.AddJsonFile("config.json", optional: true, reloadOnChange: true)
                //.Build();

            container
                .Configure<MessageBrokerSettings>(configuration)
                ;

            return container
                .AddSingleton<IRabbitMessageBrokerClient, RabbitMessageBrokerClient>();
        }
    }
}
