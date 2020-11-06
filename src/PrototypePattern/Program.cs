using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ConcretePrototype no0 = new ConcretePrototype() { Number = 0, Person = new Person() { Age = 17, Name = "Vincent" } };
                Console.WriteLine("第一次构造");
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");

                Console.WriteLine("从No0浅克隆到No1");
                ConcretePrototype no1 = (ConcretePrototype)no0.Clone();

                Console.WriteLine("修改No1");
                no1.Person.Age = 18;
                no1.Person.Name = "Vincent1";
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");
                Console.WriteLine($"No1：Number:{no1.Number}，Age:{no1.Person.Age}，Name:{no1.Person.Name}");
                Console.WriteLine("******************");

                Console.WriteLine("从No0浅克隆到No2");
                ConcretePrototype no2 = (ConcretePrototype)no0.DeepClone();
                Console.WriteLine("修改No2");
                no2.Person.Age = 19;
                no2.Person.Name = "Vincent2";
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");
                Console.WriteLine($"No2：Number:{no2.Number}，Age:{no2.Person.Age}，Name:{no2.Person.Name}");
                Console.WriteLine("******************");
            }
            Console.WriteLine("————————————————————————————————————————");
            {
                ConcretePrototype2 no0 = new ConcretePrototype2() { Number = 0, Person = new Person() { Age = 17, Name = "Vincent" } };
                Console.WriteLine("第一次构造");
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");

                Console.WriteLine("从No0浅克隆到No1");
                ConcretePrototype2 no1 = (ConcretePrototype2)no0.Clone();

                Console.WriteLine("修改No1");
                no1.Person.Age = 18;
                no1.Person.Name = "Vincent1";
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");
                Console.WriteLine($"No1：Number:{no1.Number}，Age:{no1.Person.Age}，Name:{no1.Person.Name}");
                Console.WriteLine("******************");

                Console.WriteLine("从No0浅克隆到No2");
                ConcretePrototype2 no2 = no0.DeepClone<ConcretePrototype2>();
                Console.WriteLine("修改No2");
                no2.Person.Age = 19;
                no2.Person.Name = "Vincent2";
                Console.WriteLine($"No0：Number:{no0.Number}，Age:{no0.Person.Age}，Name:{no0.Person.Name}");
                Console.WriteLine($"No2：Number:{no2.Number}，Age:{no2.Person.Age}，Name:{no2.Person.Name}");
                Console.WriteLine("******************");
            }

            Console.ReadKey();


        }
    }
}
