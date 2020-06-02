using System;

namespace Microservice.RabbitMQMessageBrokerExtension.Unit.Tests
{
    public static  class TestObjectMother
    {
        public static TestObject GetBasicTestObject()
        {
            return new TestObject
            {
                Age = 27,
                DateOfBirth = new DateTime(1945),
                Name = "Winston Churchill"
            };
        }
    }
}
