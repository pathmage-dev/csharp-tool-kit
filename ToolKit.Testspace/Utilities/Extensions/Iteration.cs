namespace ToolKit.Testspace.Utilities.Extensions;

public class Iteration
{
	public static void ForeachInt()
	{
		// foreach (var i in -1)
		// 	print(i);

		print("i in 0");
		foreach (var i in 0)
			print(i);

		print("i in 1");
		foreach (var i in 1)
			print(i);

		print("i in 10");
		foreach (var i in 10)
			print(i);

		int[] values = [1, 2, 3, 4, 5];
		print("i in values.Length");
		foreach (var i in values.Length)
			print(i, values[i]);
	}

	public static void ForeachIndex()
	{
		// foreach (var i in ^-1)
		// print(i);

		// foreach (var i in new Index(10))
		// 	print(i);

		print("i in ^0");
		foreach (var i in ^0)
			print(i);

		print("i in ^1");
		foreach (var i in ^1)
			print(i);

		print("i in ^10");
		foreach (var i in ^10)
			print(i);

		int[] values = [1, 2, 3, 4, 5];
		print("i in ^values.Length");
		foreach (var i in ^values.Length)
			print(i, values[i]);
	}

	public static void RangeTest()
	{
		var range = ..10;
		print(range.Start.IsFromEnd, range.End.IsFromEnd);

		range = 10..;
		print(range.Start.IsFromEnd, range.End.IsFromEnd);
	}

	public static void ForeachRange()
	{
		// foreach (var i in ..-1)
		// print(i);

		print("i in ..0");
		foreach (var i in ..0)
			print(i);

		print("i in ..1");
		foreach (var i in ..1)
			print(i);

		print("i in ..10");
		foreach (var i in ..10)
			print(i);

		int[] values = [1, 2, 3, 4, 5];
		print("i in 2..values.Length");
		foreach (var i in 2..values.Length)
			print(i, values[i]);
	}

	public static void ForeachRangeBackwards()
	{
		// foreach (var i in -1..)
		// print(i);

		print("i in 0..");
		foreach (var i in 0..)
			print(i);

		print("i in 1..");
		foreach (var i in 1..)
			print(i);

		print("i in 10..");
		foreach (var i in 10..)
			print(i);

		int[] values = [1, 2, 3, 4, 5];
		print("i in values.Length..2");
		foreach (var i in values.Length..2)
			print(i, values[i]);
	}
}
