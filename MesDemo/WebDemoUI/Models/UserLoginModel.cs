using System;
using Microsoft.AspNetCore.Http;
using System.Web.Security;
using System.Web.Script.Serialization;

namespace MesDemo.WebUI.admin
{
    public class UserLogin
    {
        public void ProcessRequest(HttpContext Context)
        {
            Context.Request.ContentType = "application/json";
            string action = Context.Request.Query["action"];

            try
            {
                switch (action)
                {
                    case "getuser":
                        if (Context.Request.IsHttps)
                        {

                        }
                }
            }
        }
    }
}