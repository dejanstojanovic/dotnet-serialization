using ProtoBuf;
using System.IO;

namespace ProtobufSample.Serializers
{
    public class ProtobufSerializer<T> : ISerializer<T>
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
