using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serialization.Samples.Serializers;
using Serialization.Samples.Tests.Models;

namespace Serialization.Samples.Tests
{
    [TestClass]
    public class SerializersTest
    {
        public readonly Person inputModel = new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Smith",
            DOB = new DateTime(1984, 12, 30)
        };

        private bool PropertyValueCompare(Person object1, Person object2)
        {
            return
                object1.Id == object2.Id &&
                object1.FirstName == object2.FirstName &&
                object1.LastName == object2.LastName &&
                object2.DOB == object2.DOB;
        }

        private void AssertTest(ISerializer<Person> serializer)
        {
            var serialized = serializer.Serialize(inputModel);
            Person deserialized = serializer.Deserialize(serialized);
            Assert.IsTrue(PropertyValueCompare(inputModel, deserialized));
        }


        [TestMethod]
        public void BinaryTest()
        {
            AssertTest(new SampleBinarySerializer<Person>());
        }

        [TestMethod]
        public void XmlTest()
        {
            AssertTest(new SampleXmlSerializer<Person>());
        }

        [TestMethod]
        public void JsonTest()
        {
            AssertTest( new SampleJsonSerializer<Person>());
        }

        [TestMethod]
        public void ProtobufTest()
        {
            AssertTest(new SampleProtobufSerializer<Person>());
        }

        [TestMethod]
        public void AvroTest()
        {
            AssertTest(new SampleAvroSerializer<Person>());
        }

    }
}
