using _2WayMessenger.Model;
using _2WayMessenger.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _2wayMessenger.Repository.Repository
{
    public class ExceptionLoggerRepository
    {
        private readonly appContext _context;
        private readonly RequestDelegate _next;
        //private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionLoggerRepository(appContext context)
        {
            _context = context;
        }

        public void Insert(ExceptionLog exceptionLog)
        {
            // Get the method name where the error occurred.
            var stackTrace = new StackTrace();
            var methodName = stackTrace?.GetFrame(1)?.GetMethod()?.Name;

            // Set the method name in the exception log.
            exceptionLog.RepositoryName = methodName;

            // Insert the exception log into the database.
            _context.ExceptionLogs.Add(exceptionLog);
            _context.SaveChanges();
        }
    }


}
