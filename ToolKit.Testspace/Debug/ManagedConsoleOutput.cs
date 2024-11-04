using ToolKit.Debug;

namespace ToolKit.Testspace.Debug;

public class ManagedConsoleOutputTest
{
	public static void Test()
	{
		Project.ConsoleOutput = new ManagedConsoleOutput(Console.WriteLine);

		write('A');
		print('B');
	}
}
