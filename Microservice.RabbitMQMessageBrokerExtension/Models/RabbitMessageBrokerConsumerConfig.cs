using Microservice.RabbitMQMessageBrokerExtension.Logger;

namespace Microservice.RabbitMQMessageBrokerExtension.Models
{
    public class MessageBrokerConsumerConfig
    {
        public bool UseBasicQos { get; set; } = false;
        public ushort BasicQosPrefetch { get; set; } = 1;
        public IMessageBrokerDefaultLogger SubscriptionLogger { get; set; }
    }
}
