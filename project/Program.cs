Console.WriteLine("Сколько слов будем проверять?");
int sizeA = Convert.ToInt32(Console.ReadLine());
int count = 0;
string[] arraySource = new string[sizeA];

for (int i = 0; i < sizeA; i++)
{

  Console.WriteLine($"Введите {i + 1}-е слово");
  arraySource[i] = Console.ReadLine();
  if (arraySource[i].Length <= 3)
  {
    count++;
  }
}


string[] arrayResult = new string[count];
int k = 0;
for (int j = 0; j < arraySource.Length; j++)
{
  if(arraySource[j].Length <= 3)
    {
      arrayResult[k] = arraySource[j];
      k++;
    } 
}


  // Функция вывода массива
  void printArray(string[] arrayToPrint)
  {
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
      Console.Write(arrayToPrint[i]);
      if (i != arrayToPrint.Length - 1)
      {
        Console.Write(", ");
      }
    }
    Console.Write("]");
  }


  printArray(arraySource);
  printArray(arrayResult);