namespace BuilderPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // 客户找到电脑城老板说要买电脑，这里要装两台电脑
            // 创建指挥者和构造者
            var director = new Director();
            AbstractBuilder b1 = new ConcreteBuilder1();
            AbstractBuilder b2 = new ConcreteBuilder2();

            // 老板叫员工去组装第一台电脑
            director.Construct(b1);

            // 组装完，组装人员搬来组装好的电脑
            var computer1 = b1.GetComputer();
            computer1.Show();

            // 老板叫员工去组装第二台电脑
            director.Construct(b2);
            var computer2 = b2.GetComputer();
            computer2.Show();

            Console.Read();
        }
    }
}
