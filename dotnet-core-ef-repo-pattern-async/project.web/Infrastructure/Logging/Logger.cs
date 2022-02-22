using Serilog;
using Serilog.Enrichers;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static project.web.Infrastructure.Constants;

namespace project.web.Infrastructure.Logging
{
    public static class Logger
    {
        public static ILogger CreateSerilogLogger()
        {
            const string loggerTemplate = @"{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u4}]<{ThreadId}> [{SourceContext:l}] {Message:lj}{NewLine}{Exception}";

            var dir = Path.Combine(Directory.GetCurrentDirectory(), "application_data", "logs");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var logfile = Path.Combine(dir, LoggingConstants.LOG_FILE_NAME);

            return new LoggerConfiguration().MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                                  .Enrich.With(new ThreadIdEnricher())
                                                  .Enrich.FromLogContext()
                                                  .WriteTo.File(logfile,
                                                                LogEventLevel.Information,
                                                                loggerTemplate,
                                                                rollingInterval: RollingInterval.Day,
                                                                retainedFileCountLimit: 90)
                                                  .CreateLogger();
        }
    }
}
