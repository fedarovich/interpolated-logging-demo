using System.Runtime.CompilerServices;

namespace InterpolatedLoggingDemo;

[InterpolatedStringHandler]
public ref struct StructuredLoggingInterpolatedStringHandler
{
    private readonly StringBuilder _template = null!;
    private readonly ArgumentList _arguments = null!;

    public bool IsEnabled { get; }

    public StructuredLoggingInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, LogLevel logLevel, out bool isEnabled)
    {
        IsEnabled = isEnabled = logger.IsEnabled(logLevel);
        if (isEnabled)
        {
            _template = new (literalLength + 20 * formattedCount);
            _arguments = new (formattedCount);
        }
    }

    public void AppendLiteral(string s)
    {
        if (!IsEnabled) 
            return;

        _template.Append(s.Replace("{", "{{", StringComparison.Ordinal).Replace("}", "}}", StringComparison.Ordinal));
    }

    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "")
    {
        if (!IsEnabled)
            return;

        _arguments.Add(value);
        _template.Append($"{{@{name}}}");
    }

    public (string, object?[]) GetTemplateAndArguments() => (_template.ToString(), _arguments.Arguments);

    private class ArgumentList
    {
        private int _index;

        public object?[] Arguments { get; }

        public ArgumentList(int formattedCount) => Arguments = new object?[formattedCount];

        public void Add(object? value) => Arguments[_index++] = value;
    }
}
