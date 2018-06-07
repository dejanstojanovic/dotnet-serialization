namespace Serialization.Samples.Serializers
{
    public class BinarySerializer<T> : ISerializer<T>
    {
        public T Deserialize(byte[] arrayToDeserialize)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Serialize(T objectToSerialize)
        {
            throw new System.NotImplementedException();
        }
    }
}
