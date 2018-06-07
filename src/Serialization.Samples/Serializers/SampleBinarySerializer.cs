using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Samples.Serializers
{
    public class SampleBinarySerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(arrayToDeserialize))
            {
                return binaryFormatter.Deserialize(memoryStream) as T;
            }
        }

        public byte[] Serialize(T objectToSerialize)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, objectToSerialize);
                return memoryStream.ToArray();
            }
        }
    }
}
