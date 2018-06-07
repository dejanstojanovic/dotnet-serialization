namespace Serialization.Samples.Serializers
{
    public interface ISerializer<T>
    {
        byte[] Serialize(T objectToSerialize);
        T Deserialize(byte[] arrayToDeserialize);

    }
}
