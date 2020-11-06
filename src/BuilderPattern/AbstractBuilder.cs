namespace BuilderPattern
{
    /// <summary>
    ///     抽象建造者，这个场景下为 "组装人" ，这里也可以定义为接口
    /// </summary>
    public abstract class AbstractBuilder
    {
        /// <summary>
        /// 装CPU
        /// </summary>
        public abstract void BuildPartCPU();

        /// <summary>
        /// 装主板
        /// </summary>
        public abstract void BuildPartMainBoard();

        /// <summary>
        /// 获得组装好的电脑
        /// </summary>
        /// <returns>电脑</returns>
        public abstract Computer GetComputer();
    }
}