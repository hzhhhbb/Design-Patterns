namespace PrototypePattern
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public abstract class AbstractPrototype 
    {
        /// <summary>
        /// 浅克隆
        /// <remarks>使用objectMemberwiseClone</remarks>
        /// </summary>
        /// <returns>当前对象副本</returns>
        public virtual AbstractPrototype Clone()
        {
            return (AbstractPrototype)this.MemberwiseClone();
        }

        /// <summary>
        /// 深克隆
        /// <remarks>使用二进制序列化反序列化实现</remarks>
        /// </summary>
        /// <returns>当前对象副本</returns>
        public virtual AbstractPrototype DeepClone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, this);
            stream.Position = 0;
            var instance = (AbstractPrototype)binaryFormatter.Deserialize(stream);
            stream.DisposeAsync();
            return instance;
        }
    }
}
