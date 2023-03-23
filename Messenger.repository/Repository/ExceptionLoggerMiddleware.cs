using _2WayMessenger.Model;
using _2WayMessenger.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _2wayMessenger.Repository
{
    public class ExceptionLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly appContext _exceptionRepository;

        public ExceptionLoggerMiddleware(RequestDelegate next, appContext exceptionRepository)
        {
            _next = next;
            _exceptionRepository = exceptionRepository;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var stackTrace = new StackTrace(ex);                
                // Log the exception details into the database using a repository.
                var exceptionLog = new ExceptionLog
                {
                    ExceptionMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    ApiName = stackTrace.GetFrame(1)?.GetMethod()?.Name,
                    RepositoryName = stackTrace.GetFrame(0)?.GetMethod()?.Name,
                    Date = DateTime.UtcNow
                };
                _exceptionRepository.ExceptionLogs.Add(exceptionLog);
                _exceptionRepository.SaveChanges();
                //context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                var result = JsonSerializer.Serialize(new { error = ex.Message });
                await context.Response.WriteAsync(result);
            }
        }
    }

}
