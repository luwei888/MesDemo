using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDemo.DALFactory
{
    /// <summary>
    /// 工厂类：创建数据库的实例对象
    /// </summary>
    public class Factory
    {
        private static object GetInstance(string name)
        {
            string configName = System.Configuration.ConfigurationManager.AppSettings["DataAccess"];
            if (string.IsNullOrEmpty(configName))
            {
                throw new InvalidOperationException();
            }

            string className = string.Format("{0}.{1}", configName, name);  //ZGZY.SQLServerDAL.传入的类名name

            //加载程序集
            System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(configName);
            //创建指定类型的对象实例
            return assembly.CreateInstance(className);

        }

        public static MesDemo.IDAL.ILoginLog GetLoginInfoDAL()
        {
            MesDemo.IDAL.ILoginLog loginInfo = GetInstance("loginLog") as MesDemo.IDAL.ILoginLog;
            return loginInfo;
        }

    }
}
