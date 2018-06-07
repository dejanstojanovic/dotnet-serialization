using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtobufSample.Serializers
{
    public interface ISerializer<T>
    {
        byte[] Serialize(T objectToSerialize);
        T Deserialize(byte[] arrayToDeserialize);

    }
}
