namespace TemplateMethodPattern
{
    using System;

    public class ConcreteSave1 : AbstractSave
    {
        public override void BeforeSave()
        {
            Console.WriteLine("数据B保存前的校验");
        }

        public override void AfterSave()
        {
            Console.WriteLine("数据B保存后的操作");
        }
    }
}
