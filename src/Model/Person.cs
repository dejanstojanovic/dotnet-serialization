using System;
using ProtoBuf;

namespace ProtobufSample.Model
{
    [ProtoContract]
    public class Person
    {
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [ProtoMember(2)]
        public String FirstName { get; set; }

        [ProtoMember(3)]
        public String LastName { get; set; }

        [ProtoMember(4)]
        public DateTime DOB { get; set; }


    }
}
