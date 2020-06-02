using Microservice.RabbitMQMessageBrokerExtension.Models;

namespace Microservice.RabbitMQMessageBrokerExtension.Builder
{
    public class MessageBrokerConfigBuilder
    {
        public MessageBrokerConsumerConfig Config { get; set; }
        public MessageBrokerConfigBuilder()
        {
            Config = new MessageBrokerConsumerConfig();
        }

        public MessageBrokerConfigBuilder UseBasicQos(bool useBasicQos = true, ushort basicQosPrefetch = 1)
        {
            Config.BasicQosPrefetch = basicQosPrefetch;
            Config.UseBasicQos = useBasicQos;
            return this;
        }
    }
}
