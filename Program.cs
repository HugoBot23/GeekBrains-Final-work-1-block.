// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();

string[] line = { "Hi", "this", "is", "my", "1st", "final", "work", "fan", ";-)" };
string[] array = MaximumaArrayLength(line, 3);

Console.WriteLine($"[{string.Join(", ", line)}] -> [{string.Join(", ", array)}]");

string[] MaximumaArrayLength(string[] line, int maxLength)
{
  string[] NewArrayLine = new string[NewString(line, maxLength)];

  for (int i = 0, j = 0; i < line.Length; i++)
  {
    if (line[i].Length <= maxLength)
    {
      NewArrayLine[j] = line[i];
      j++;
    }
  }
  return NewArrayLine;
}

int NewString(string[] line, int maxLength)
{
  int count = 0;
  for (int i = 0; i < line.Length; i++)
  {
    if (line[i].Length <= maxLength)
    {
      count++;
    }
  }
  return count;
}