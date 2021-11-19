using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;
using InterpolatedLogging;
using static InterpolatedLogging.NamedProperties;

namespace InterpolatedLoggingDemoBenchmarks
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        private static readonly InterpolatedLoggingDemo.Segment Segment = new(new(1, 2), new(4, 6));

        private static readonly Action<ILogger, InterpolatedLoggingDemo.Segment, double, Exception?> _logSegmentLength = LoggerMessage.Define<InterpolatedLoggingDemo.Segment, double>(
            logLevel: LogLevel.Information,
            eventId: 0,
            formatString: "The length of the segment {@segment} is {@length}.");

        private ILoggerFactory _loggerFactory = null!;
        private ILogger _logger = null!;   

        [ParamsAllValues]
        public bool IsEnabled { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Serilog.Log.Logger = new Serilog.LoggerConfiguration()
                .MinimumLevel.Is(IsEnabled ? Serilog.Events.LogEventLevel.Information : Serilog.Events.LogEventLevel.Error)
                .CreateLogger();

            _loggerFactory = LoggerFactory.Create(builder => Serilog.SerilogLoggingBuilderExtensions.AddSerilog(builder, dispose: true));
            _logger = _loggerFactory.CreateLogger<Benchmark>();
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _loggerFactory.Dispose();
        }

        [Benchmark(Baseline = true)]
        public void TemplateAndArgs()
        {
            const double length = 5;
            _logger.LogInformation("The length of the segment {@segment} is {@length}.", Segment, length);
        }

        //[Benchmark]
        //public void InterpolatedString()
        //{
        //    const double length = 5;
        //    _logger.LogInformation($"The length of the segment {Segment} is {length}.");
        //}

        [Benchmark]
        public void InterpolatedHandler()
        {
            const double length = 5;
            InterpolatedLoggingDemo.LoggerExtensions.LogInformation(_logger, $"The length of the segment {Segment} is {length}.");
        }

        [Benchmark]
        public void LoggerMessageDelegate()
        {
            const double length = 5;
            _logSegmentLength(_logger, Segment, length, null);
        }

        [Benchmark]
        public void FormattableString()
        {
            const double length = 5;
            _logger.InterpolatedInformation($"The length of the segment {Segment:@Segment} is {length:@length}.");
        }

        [Benchmark]
        public void FormattableStringNP()
        {
            const double length = 5;
            _logger.InterpolatedInformation($"The length of the segment {NP(Segment, "@Segment")} is {NP(length, "@length")}.");
        }

        [Benchmark]
        public void FormattableStringAnonymous()
        {
            const double length = 5;
            _logger.InterpolatedInformation($"The length of the segment @{new {Segment = Segment }} is @{new { length = length }}.");
        }
    }
}
