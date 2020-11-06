using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
   public abstract class AbstractSave
   {
       public abstract void BeforeSave();

       public abstract void AfterSave();

       public void SaveData()
       {
           Console.WriteLine("数据成功保存到数据库");
       }

       public void Save()
       {
           this.BeforeSave();
           this.SaveData();
           this.AfterSave();
       }
   }
}
