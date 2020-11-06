namespace TemplateMethodPattern
{
    using System;

    public class ConcreteSave : AbstractSave
    {
        public override void BeforeSave()
        {
            Console.WriteLine("数据A保存前的校验");
        }

        public override void AfterSave()
        {
            Console.WriteLine("数据A保存后的操作");
        }
    }
}
