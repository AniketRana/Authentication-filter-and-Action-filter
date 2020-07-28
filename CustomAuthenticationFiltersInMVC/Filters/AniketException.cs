using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthenticationFiltersInMVC.Filters
{
    public class AniketException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //For identifying types of exception
            if (filterContext.Exception is NotImplementedException)
            {

            }
            else if (filterContext.Exception is DivideByZeroException)
            {

            }

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            filterContext.ExceptionHandled = true;
            //throw new NotImplementedException();
        }
    }
}