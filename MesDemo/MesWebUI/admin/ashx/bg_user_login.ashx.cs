using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MesWebUI.admin.ashx
{
    /// <summary>
    /// bg_user_login 的摘要说明
    /// </summary>
    public class bg_user_login : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string action = context.Request.Params["action"];

            try
            {
                string Common = null;
                switch (action)
                {
                    case "getuser":

                    case "login":
                        string userIp = context.Request.UserHostAddress;
                        string city = context.Request.Params["city"]??"未知";
                        string remember = context.Request.Params["remember"] ?? "未知";
                        string name = context.Request.Params["loginName"];
                        string pwd = MesDemo.Common.Md5.GetMD5String(context.Request.Params["loginPwd"]);
                        DateTime? lastLoginTime;
                        if (true)
                        {

                        }

                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}