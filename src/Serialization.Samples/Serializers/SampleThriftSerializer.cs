using System;
using System.IO;
using Thrift.Protocol;
using Thrift.Transport;

namespace Serialization.Samples.Serializers
{
    public class SampleThriftSerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {

            using (var stream = new MemoryStream(arrayToDeserialize))
            {
                TProtocol tProtocol = new TBinaryProtocol(new TStreamTransport(stream, stream));

                return messageObject.Read(tProtocol) as T;
            }
        }


        public byte[] Serialize(T objectToSerialize)
        {
            using (var stream = new MemoryStream())
            {

                TProtocol tProtocol = new TBinaryProtocol(new TStreamTransport(stream, stream));
                objectToSerialize.Write(tProtocol);

                return stream.ToArray();
            }


        }
    }
}
