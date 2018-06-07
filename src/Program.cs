using ProtoBuf;
using Serialization.Samples.Models;
using Serialization.Samples.Serializers;
using System;
using System.IO;

namespace Serialization.Samples
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            ISerializer<Person> serializer= new ProtobufSerializer<Person>();

            var serialized = serializer.Serialize(new Person() {
                Id=Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                DOB = new DateTime(1984, 12, 30)
            });

            Person deserialized = serializer.Deserialize(serialized);
        }


    }
}
