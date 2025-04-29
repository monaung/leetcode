// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IsPrime(19);
bool IsPrime(int num)
{
  if (num <= 1) return false;
  if (num == 2) return true;

  double sqroot = Math.Sqrt(num);

  for (int i = 2; i <= sqroot; i++)
  {
    if (num % i == 0)
      return false;
  }
  return true;

}