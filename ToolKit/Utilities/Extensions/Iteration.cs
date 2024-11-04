namespace ToolKit;

partial class Extensions
{
	public static Iterator GetEnumerator(this int end_at)
	{
#if ERR
		ArgumentOutOfRangeException.ThrowIfLessThan(end_at, 0);
#endif
		return new Iterator(end_at);
	}

	public ref struct Iterator(int end_at)
	{
		public int Current { get; private set; } = -1;
		readonly int end_at = end_at;

		public bool MoveNext() => ++Current < end_at;
	}

	public static ReverseIterator GetEnumerator(this Index start_before)
	{
#if ERR
		ArgumentOutOfRangeException.ThrowIfEqual(start_before.IsFromEnd, false);
#endif
		return new ReverseIterator(start_before.Value);
	}

	public ref struct ReverseIterator(int start_before)
	{
		public int Current { get; private set; } = start_before;

		public bool MoveNext() => -1 < --Current;
	}

	public static RangeIterator GetEnumerator(this Range range)
	{
		if (range.Start.Value < range.End.Value)
		{
#if ERR
			ArgumentOutOfRangeException.ThrowIfEqual(range.Start.IsFromEnd, true);
			ArgumentOutOfRangeException.ThrowIfEqual(range.End.IsFromEnd, true);
#endif
			return new RangeIterator(range.Start.Value - 1, range.End.Value, 1);
		}

#if ERR
		ArgumentOutOfRangeException.ThrowIfEqual(range.Start.IsFromEnd, true);
		ArgumentOutOfRangeException.ThrowIfEqual(!range.End.Equals(^0) && range.End.IsFromEnd, true);
#endif
		return new RangeIterator(range.Start.Value, range.End.Value - 1, -1);
	}

	public ref struct RangeIterator(int start_at, int end_before, int step_by)
	{
		public int Current { get; private set; } = start_at;
		readonly int end_before = end_before;
		readonly int step_by = step_by;

		public bool MoveNext() => (Current += step_by) != end_before;
	}
}
