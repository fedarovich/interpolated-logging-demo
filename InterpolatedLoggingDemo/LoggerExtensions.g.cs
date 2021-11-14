#nullable enable
using System.Runtime.CompilerServices;
namespace InterpolatedLoggingDemo;

public static partial class LoggerExtensions
{
    
    public static void LogTrace(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(template, arguments);
        }
    }

    public static void LogTrace(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, template, arguments);
        }
    }

    public static void LogTrace(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(exception, template, arguments);
        }
    }

    public static void LogTrace(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingTraceInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogTrace(eventId, exception, template, arguments);
        }
    }
    
    public static void LogDebug(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(template, arguments);
        }
    }

    public static void LogDebug(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, template, arguments);
        }
    }

    public static void LogDebug(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(exception, template, arguments);
        }
    }

    public static void LogDebug(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingDebugInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogDebug(eventId, exception, template, arguments);
        }
    }
    
    public static void LogInformation(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(template, arguments);
        }
    }

    public static void LogInformation(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, template, arguments);
        }
    }

    public static void LogInformation(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(exception, template, arguments);
        }
    }

    public static void LogInformation(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingInformationInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogInformation(eventId, exception, template, arguments);
        }
    }
    
    public static void LogWarning(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(template, arguments);
        }
    }

    public static void LogWarning(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, template, arguments);
        }
    }

    public static void LogWarning(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(exception, template, arguments);
        }
    }

    public static void LogWarning(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingWarningInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogWarning(eventId, exception, template, arguments);
        }
    }
    
    public static void LogError(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(template, arguments);
        }
    }

    public static void LogError(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, template, arguments);
        }
    }

    public static void LogError(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(exception, template, arguments);
        }
    }

    public static void LogError(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingErrorInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogError(eventId, exception, template, arguments);
        }
    }
    
    public static void LogCritical(this ILogger logger, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(template, arguments);
        }
    }

    public static void LogCritical(this ILogger logger, EventId eventId, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, template, arguments);
        }
    }

    public static void LogCritical(this ILogger logger, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(exception, template, arguments);
        }
    }

    public static void LogCritical(this ILogger logger, EventId eventId, Exception? exception, [InterpolatedStringHandlerArgument("logger")] ref StructuredLoggingCriticalInterpolatedStringHandler handler)
    {
        if (handler.IsEnabled)
        {
            var (template, arguments) = handler.GetTemplateAndArguments();
            logger.LogCritical(eventId, exception, template, arguments);
        }
    }
    }
