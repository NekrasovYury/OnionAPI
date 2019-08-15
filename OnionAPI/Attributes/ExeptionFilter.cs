using NLog;
using System;
using System.Web.Http.Filters;

namespace OnionAPI.Attributes
{
    public class ExeptionFilter : ExceptionFilterAttribute
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            logger.SetProperty("controller", actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
            logger.Error(actionExecutedContext.Exception, "Error" + Environment.NewLine + DateTime.Now);
        }
    }
}