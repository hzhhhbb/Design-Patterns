namespace PrototypePattern
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    public static class ICloneableExtension
    {
        public static T DeepClone<T>(this ICloneable instance)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, instance);
            stream.Position = 0;
            var duplicate = binaryFormatter.Deserialize(stream);
            stream.DisposeAsync();
            return (T)duplicate;
        }
    }
}
