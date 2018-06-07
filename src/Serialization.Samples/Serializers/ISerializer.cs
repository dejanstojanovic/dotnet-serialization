namespace Serialization.Samples.Serializers
{
    public interface ISerializer<T> where T : class
    {
        byte[] Serialize(T objectToSerialize);
        T Deserialize(byte[] arrayToDeserialize);

    }
}
