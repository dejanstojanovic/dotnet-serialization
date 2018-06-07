using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization.Samples.Serializers
{
    public class SampleXmlSerializer<T> : ISerializer<T> where T : class
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {
            using (var memStream = new MemoryStream(arrayToDeserialize))
            {
                return new XmlSerializer(typeof(T)).Deserialize(memStream) as T;
            }
        }

        public byte[] Serialize(T objectToSerialize)
        {
            using (var memStream = new MemoryStream())
            {
                new XmlSerializer(typeof(T)).Serialize(memStream, objectToSerialize);
                return memStream.ToArray();
            }

        }
    }
}
