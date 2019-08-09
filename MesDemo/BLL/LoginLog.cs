using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDemo.BLL
{
    /// <summary>
    /// 用户登录信息（BLL）
    /// </summary>
    class LoginLog
    {
        //BLL不直接访问底层数据库，调用工厂方法
        //private static MesDemo.IDAL.ILoginInfo dal;     
        //方式一：数据访问对象dal为null，通过构造函数赋值
        //public LoginInfo()
        //{
        //    //在BLL都是通过工厂创建的对象实例
        //    dal = ZGZY.DALFactory.Factory.GetLoginInfoDALs();
        //}

        //方法二
        private static readonly MesDemo.IDAL.ILoginLog dal = 

    }
}
