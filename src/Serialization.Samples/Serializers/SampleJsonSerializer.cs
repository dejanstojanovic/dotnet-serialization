using System;
using System.Text;
using Newtonsoft.Json;

namespace Serialization.Samples.Serializers
{
   public class SampleJsonSerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(Encoding.Default.GetString(arrayToDeserialize));
        }

        public byte[] Serialize(T objectToSerialize)
        {
            return Encoding.Default.GetBytes(JsonConvert.SerializeObject(objectToSerialize));
        }
    }
}
