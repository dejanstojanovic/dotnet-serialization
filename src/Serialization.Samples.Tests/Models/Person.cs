using System;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Serialization.Samples.Tests.Models
{
    [Serializable]
    [DataContract(IsReference = true, Name = "Person", Namespace = "Serialization.Samples")]
    [ProtoContract]
    public class Person
    {
        [DataMember(Name = "Id", IsRequired = false)]
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [DataMember(Name = "FirstName", IsRequired = false)]
        [ProtoMember(2)]
        public String FirstName { get; set; }

        [DataMember(Name = "LastName", IsRequired = false)]
        [ProtoMember(3)]
        public String LastName { get; set; }

        [DataMember(Name = "DOB", IsRequired = false)]
        [ProtoMember(4)]
        public DateTime DOB { get; set; }


    }
}
