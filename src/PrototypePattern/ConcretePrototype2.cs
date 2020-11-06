namespace PrototypePattern
{
    using System;

    [Serializable]
    public class ConcretePrototype2 : ICloneable
    {
        public int Number { get; set; }

        public Person Person { get; set; }

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public object Clone()
        {
           return this.MemberwiseClone();
        }
    }
}
