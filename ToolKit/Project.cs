using ToolKit.Debug;

namespace ToolKit;

public static class Project
{
	static IConsoleOutput _console_output = new SystemConsoleOutput();
	internal static object ConsoleOutputLock { get; } = new();

	public static IConsoleOutput ConsoleOutput
	{
		internal get => _console_output;
		set
		{
			lock (ConsoleOutputLock)
				_console_output = value;
		}
	}
}
