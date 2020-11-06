namespace BuilderPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     电脑类
    /// </summary>
    public class Computer
    {
        /// <summary>
        ///  电脑组件集合
        /// </summary>
        private readonly IList<string> parts = new List<string>();

        /// <summary>
        /// 把单个组件添加到电脑组件集合中
        /// </summary>
        /// <param name="part">组件</param>
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑组件清单：");
            foreach (var part in this.parts)
            {
                Console.WriteLine($"组件：{part}");
            }
            Console.WriteLine("****************");
        }
    }
}