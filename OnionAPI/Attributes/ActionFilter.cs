using NLog;
using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace OnionAPI.Attributes
{
    public class ActionFilter : ActionFilterAttribute
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            logger.SetProperty("controller", actionContext.ActionDescriptor.ActionName);
            logger.Info(Environment.NewLine + DateTime.Now);
        }
    }
}