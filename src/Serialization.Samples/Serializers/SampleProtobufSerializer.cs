using ProtoBuf;
using System.IO;

namespace Serialization.Samples.Serializers
{
    public class SampleProtobufSerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {
            using (var memStream = new MemoryStream(arrayToDeserialize))
            {
                return Serializer.Deserialize<T>(memStream);
            }
        }

        public byte[] Serialize(T objectToSerialize)
        {
            using (var memStream = new MemoryStream())
            {
                Serializer.Serialize<T>(memStream, objectToSerialize);
                return memStream.ToArray();
            }
        }
    }
}
