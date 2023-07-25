Console.Write("Enter the number of array elements: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
string[] stringArray2 = new string[stringArray.Length];
void Array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Enter {i+1} elements array ");
     stringArray[i] = Console.ReadLine();
  }
}

void SecondArray(string[] stringArray, string[] stringArray2)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
    if(stringArray[i].Length <= 3)
        {
        stringArray2[count] = stringArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
Array(stringArray);
SecondArray(stringArray,stringArray2);
PrintArray(stringArray2);










































