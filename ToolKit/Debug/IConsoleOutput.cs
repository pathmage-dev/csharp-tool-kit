namespace ToolKit.Debug;

public interface IConsoleOutput
{
	Action<string> Write { get; }
	Action WriteLine { get; }
}
