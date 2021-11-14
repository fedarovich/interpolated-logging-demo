using InterpolatedLoggingDemo;
using Serilog;
using Serilog.Formatting.Compact;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console(new CompactJsonFormatter())
    .CreateLogger();   

using var loggerFactory = LoggerFactory.Create(builder => builder.AddSerilog(dispose: true));
var logger = loggerFactory.CreateLogger<Program>();

var segment = new Segment(new (1, 2), new (4, 6));
var length = segment.GetLength();

logger.LogInformation($"The length of segment {segment} is {length}.");
