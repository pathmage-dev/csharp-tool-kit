﻿namespace pathmage.ToolKit.Tests.Collections;

public class Pool
{
	public static void From()
	{
		Console.WriteLine(
			"H5ello, 4Worl343d!".TrimAllExcept(
				Constants.Text.LetterChars,
				Constants.Text.NumberChars
			)
		);

		var pool = Pool<int>.From(1, 2, 3);

		pool.Add(4, 5, 6);

		// pool.Remove(0);
		// pool.Remove(2);

		// print('i', pool.Add(34));
		// print('i', pool.Add(4));

		foreach (var i in pool)
			print(i);
	}
}
