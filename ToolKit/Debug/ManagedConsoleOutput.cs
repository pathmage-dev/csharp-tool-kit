using System.Text;

namespace ToolKit.Debug;

public sealed class ManagedConsoleOutput : IConsoleOutput
{
	readonly StringBuilder output = new();

	public Action<string> Write { get; }
	public Action WriteLine { get; }

	public ManagedConsoleOutput(Action<string> write_line)
	{
		Write = value => output.Append(value);

		WriteLine = () =>
		{
			write_line(output.ToString());
			output.Clear();
		};
	}
}
