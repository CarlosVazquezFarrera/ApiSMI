namespace SMI.Infrastructure.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using SMI.Core.Exceptios;
    using System;
    using System.Net;

    public class GlobalExeptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BussinessExecption))
            {
                var exception = (BussinessExecption)context.Exception;
                var validaton = new { 
                    Staus = 400,
                    Tittle = "Bad Request",
                    Detail = exception.Message
                };
                var json = new { 
                    erros = new[] { validaton}
                };

                context.Result = new BadRequestObjectResult(json);

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
        }
    }
}
