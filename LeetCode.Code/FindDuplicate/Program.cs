// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 1, 2, 3, 2, 1, 4, 5, 4 };
List<int> duplicates = FindDuplicates(nums);

foreach (var item in duplicates)
{
  Console.WriteLine(item);
}

 static List<int> FindDuplicates(int[] nums)
{
  //List<int> dup = new List<int>();

  //HashSet<int> set1 = new HashSet<int>();

  //foreach (var item in nums)
  //{
  //  if (set1.Contains(item))
  //    dup.Add(item);
  //  else
  //    set1.Add(item);
  //}

  //return dup;
  Dictionary<int, int> numCounts = new Dictionary<int, int>();

  foreach (int num in nums)
  {
    if (numCounts.ContainsKey(num))
      numCounts[num]++;
    else
      numCounts[num] = 1;
  }

  List<int> duplicates = new List<int>();
  foreach (KeyValuePair<int, int> entry in numCounts)
  {
    if (entry.Value > 1)
    {
      duplicates.Add(entry.Key);
    }
  }

  return duplicates;
}