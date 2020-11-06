namespace PrototypePattern
{
    using System;

    [Serializable]
    public class ConcretePrototype : AbstractPrototype
    {
        public int Number { get; set; }

        public Person Person { get; set; }
    }
}
