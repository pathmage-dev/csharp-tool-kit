namespace ToolKit.Testspace.Utilities.Extensions;

public class Convert
{
	public static void ToText()
	{
		object? value;

		value = null;
		print(value.ToText());

		value = "";
		print(value.ToText());

		value = "A";
		print(value.ToText());

		value = new ToStringNull();
		print(value.ToText());
	}
}

public class ToStringNull
{
	public override string? ToString() => null;
}
