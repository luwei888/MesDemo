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