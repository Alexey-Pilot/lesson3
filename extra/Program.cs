Console.Clear();
Console.Write("Введите число кустов: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] list = new int[len];
for (int i = 0; i < len; i++)
{
  Console.Write($"Введите урожайность куста № {i + 1}: ");
  list[i] = Convert.ToInt32(Console.ReadLine());
  //Console.WriteLine(list[i]);
}
int maxBerryes = 0;
int berryes = 0;
for (int i = 0; i < len; i ++)
{
  if (i < len - 2) 
  {
    berryes = list[i] + list[i + 1] + list[i + 2];
  }
  else if(i == len - 2)
  {
    berryes = list[i] + list[i + 1] + list[0];
  }
  else 
  {
    berryes = list[i] + list[0] + list[1];
  }
  if (berryes > maxBerryes)
  {
    maxBerryes = berryes;
  }
}
Console.WriteLine($"Максимальное колличество ягодб которое может собрать робот за один заход: {maxBerryes}");