using Domain.Interface;
using Domain.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace OnionAPI.Attributes
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var logServices = GetService<ILogService>(actionContext);

            string rawRequest;
            using (var stream = new StreamReader(actionContext.Request.Content.ReadAsStreamAsync().Result))
            {
                stream.BaseStream.Position = 0;
                rawRequest = stream.ReadToEnd();
            }

            logServices.LogRequest(new RequestInfo()
            {
                ClientIP = GetClientIPAddress(actionContext.Request),
                Controller = actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                Request = rawRequest
            });
        }

        public string GetClientIPAddress(HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return IPAddress.Parse(((HttpContextBase)request.Properties["MS_HttpContext"]).Request.UserHostAddress).ToString();
            }
            return String.Empty;
        }

        private T GetService<T>(HttpActionContext actionContext)
        {
            return (T)actionContext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }

}
