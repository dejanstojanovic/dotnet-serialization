using Microsoft.Hadoop.Avro;
using System.IO;

namespace Serialization.Samples.Serializers
{
    public class AvroSerializer<T> : ISerializer<T>
    {

        private readonly IAvroSerializer<T> avroSerializer;
        public AvroSerializer()
        {
            avroSerializer = AvroSerializer.Create<T>();
        }

        public T Deserialize(byte[] arrayToDeserialize)
        {

            using (var memStream = new MemoryStream(arrayToDeserialize))
            {
                return avroSerializer.Deserialize(memStream);
            }
        }

        public byte[] Serialize(T objectToSerialize)
        {
            using (var memStream = new MemoryStream())
            {
                avroSerializer.Serialize(memStream, objectToSerialize);
                return memStream.ToArray();
            }
        }
    }
}
