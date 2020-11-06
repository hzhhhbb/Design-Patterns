namespace BuilderPattern
{
    /// <summary>
    ///   指挥者
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 组装电脑
        /// </summary>
        /// <param name="abstractBuilder">建造者</param>
        public void Construct(AbstractBuilder abstractBuilder)
        {
            abstractBuilder.BuildPartCPU();
            abstractBuilder.BuildPartMainBoard();
        }
    }
}