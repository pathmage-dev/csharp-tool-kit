namespace ToolKit.Debug;

public static class ConsoleOutputInterface
{
	public static void write(params object?[] values)
	{
		var output = string.Concat(values);

		lock (Project.ConsoleOutputLock)
			Project.ConsoleOutput.Write(output);
	}

	public static void writeln(params object?[] values)
	{
		var output = string.Concat(values);

		lock (Project.ConsoleOutputLock)
		{
			Project.ConsoleOutput.Write(output);
			Project.ConsoleOutput.WriteLine();
		}
	}

	public static void print(params object?[] values)
	{
		var text_values = new string[values.Length];

		for (var i = 0; i < values.Length; i++)
			text_values[i] = values[i].ToText();

		var output = string.Join(' ', text_values);

		lock (Project.ConsoleOutputLock)
		{
			Project.ConsoleOutput.Write(output);
			Project.ConsoleOutput.WriteLine();
		}
	}
}
