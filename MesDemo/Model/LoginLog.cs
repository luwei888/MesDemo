using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDemo.Model
{
    /// <summary>
    /// 用户登陆日志类
    /// </summary>
    public class LoginLog
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户登陆ip
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// 用户登陆城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 是否登陆成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 登陆时间
        /// </summary>
        public DateTime LoginDate { get; set; }
    }
}
