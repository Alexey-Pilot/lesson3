Console.Clear();
Console.Write("Введите пятизначное число: "); // можно и не пятизначных
string num = Console.ReadLine();
int len = num.Length;
int x = Convert.ToInt32(num);
/*while (9999 > x || x > 100000) // проверка на пятизначность
{
  Console.Write("Введите пятизначное число: ");
  x = Convert.ToInt32(Console.ReadLine());
}*/
for(int i = 0; i <= len / 2; i++)
{
  int n = x % 10;
  int m = (int)(x / Math.Pow(10, len - 1  - i * 2));
  x = (x - x / (int)Math.Pow(10, len - 1 - i * 2) * (int)Math.Pow(10, len - 1 - i * 2)) / 10;
  if (m != n || len == 1)
  {
    Console.WriteLine("No Palindrome!");
    break;
  }
  else if (i == len / 2 - 1)
  {
   Console.WriteLine("Palindrome!");
  }
}