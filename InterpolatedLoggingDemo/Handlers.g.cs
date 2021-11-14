#nullable enable
using System.Runtime.CompilerServices;
namespace InterpolatedLoggingDemo;


[InterpolatedStringHandler]
public ref struct StructuredLoggingTraceInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingTraceInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Trace, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct StructuredLoggingDebugInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingDebugInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Debug, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct StructuredLoggingInformationInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingInformationInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Information, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct StructuredLoggingWarningInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingWarningInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Warning, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct StructuredLoggingErrorInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingErrorInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Error, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct StructuredLoggingCriticalInterpolatedStringHandler
{
    private readonly StructuredLoggingInterpolatedStringHandler _handler;

    public StructuredLoggingCriticalInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        _handler = new StructuredLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Critical, out isEnabled);
    }

    public bool IsEnabled => _handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => _handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => _handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => _handler.GetTemplateAndArguments();
}
