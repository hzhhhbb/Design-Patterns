namespace BuilderPattern
{
    using System;

    using TemplateMethodPattern;

    class Program
    {
        static void Main(string[] args)
        {
            AbstractSave data1 = new ConcreteSave();
            data1.Save();

            Console.WriteLine();

            AbstractSave data2 = new ConcreteSave();
            data2.Save();
        }
    }
}
