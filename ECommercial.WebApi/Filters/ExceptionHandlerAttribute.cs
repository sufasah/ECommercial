using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ECommercial.WebApi.Filters
{
    public class ExceptionHandlerAttribute : Attribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var message = context.Exception.Message;

            context.ModelState.AddModelError("MemberException",message);

            context.ExceptionHandled=true;/// Exception handling in mvc. search it

        }
    }
}