namespace ToolKit;

partial class Extensions
{
	public static string ToText(this object? value) =>
		value switch
		{
			null => "<null>",
			string { Length: 0 } => "<empty>",
			_ => value.ToString() ?? "<ToString->null>",
		};
}
