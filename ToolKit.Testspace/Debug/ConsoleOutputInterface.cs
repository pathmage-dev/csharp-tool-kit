namespace ToolKit.Testspace.Debug;

public class ConsoleOutputInterface
{
	public static void Test()
	{
		write(1, '2', "3");
		writeln();

		writeln(1, '2', "3");

		print(null, "", 'a');
	}

	public static void MultithreadingTest()
	{
		var threads = new Thread[4];

		for (var i = 0; i < threads.Length; i++)
		{
			var ii = i;
			threads[i] = new Thread(() => threadTest(ii));
		}

		for (var i = 0; i < threads.Length; i++)
			threads[i].Start();
	}

	static void threadTest(int thread_id)
	{
		for (var i = 0; i < 10; i++)
		{
			print(thread_id, "Hello", "World!");

			Random random = new();
			Thread.Sleep(random.Next(0, 100));
		}
	}
}
