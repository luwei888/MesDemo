using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDemo.IDAL
{
    /// <summary>
    /// 登录日志接口(不同的数据库访问类实现接口达到多数据库的支持)
    /// </summary>
    public interface ILoginLog
    {
        /// <summary>
        /// 根据条件查询记录总数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int GetTotalCount(string where);

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderBy"></param>
        /// <param name="order"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        DataTable GetPager(string strWhere, string orderBy, string order, int pageIndex, int pageSize);

        /// <summary>
        /// 判断登陆：如果三十分钟内同一个ip连续5次登陆失败，那么30分钟内无法登陆
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="lastLoginTime"></param>
        /// <returns></returns>
        DateTime? CheckLogin(string ip, out DateTime? lastLoginTime);

        /// <summary>
        /// 记录用户登陆日志
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        bool WriteLoginLog(MesDemo.Model.LoginLog loginInfo);
    }
}
