namespace ToolKit.Debug;

public sealed class SystemConsoleOutput : IConsoleOutput
{
	public Action<string> Write { get; } = Console.Write;
	public Action WriteLine { get; } = Console.WriteLine;
}
