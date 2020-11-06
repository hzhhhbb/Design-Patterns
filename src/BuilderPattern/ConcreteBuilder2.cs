namespace BuilderPattern
{
    /// <summary>
    ///     具体建造者，具体的某个人为具体创建者，例如：装机小李啊
    /// </summary>
    public class ConcreteBuilder2 : AbstractBuilder
    {
        private readonly Computer computer = new Computer();

        public override void BuildPartCPU()
        {
            this.computer.Add("CPU2");
        }

        public override void BuildPartMainBoard()
        {
            this.computer.Add("Main board2");
        }

        public override Computer GetComputer()
        {
            return this.computer;
        }
    }
}