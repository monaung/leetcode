// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] array1 = { 1, 3, 5 };
int[] array2 = { 2, 4, 5 };

Console.WriteLine(ItemInCommon(array1, array2));


bool ItemInCommon(int[] array1, int[] array2)
{
	HashSet<int> set1 = new HashSet<int>(array1);
  List<int> common = new List<int>();

  foreach (int num in array2)
	{
		if (set1.Contains(num))
			common.Add(num);
	}
	Console.WriteLine("Common elements:");

	foreach (var item in common)
	{
		Console.WriteLine(item);
	}

	return common.Count > 0;
}