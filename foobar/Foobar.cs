namespace FoobarLibrary;

public class Foobar
{
	public static void GetFoobar(int x)

	{
		for (int i = 0; i <= x; i++)

		{

			if (i > 0 && i % 3 == 0)

			{
				if (i % 3 == 0 && i % 5 == 0)

				{
					Console.Write("foobar");
					if (i < x)

					{
						Console.Write(", ");
					}
				}


				else

				{
					Console.Write("foo");
					if (i < x)

					{
						Console.Write(", ");
					}

				}
			}
			else if (i > 0 && i % 5 == 0)

			{
				Console.Write("bar");
				if (i < x)

					{
						Console.Write(", ");
					}

			}
			else

			{
				// return i.ToString();
				Console.Write(i.ToString());
				if (i < x)

					{
						Console.Write(", ");
					}

			}
		}
	}
}