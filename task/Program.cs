Console.WriteLine("Введите количество элементов массива: ");
int  n = Convert.ToInt32(Console.ReadLine());

string [] array = new string[n];
string [] newArray = new string[n];
int j = 0;
for (int i = 0; i < n; i++)
{
   Console.WriteLine("Введите элемент массива: ");
   array[i] = Console.ReadLine();

   if (array[i].Length <=3 )
   {
    newArray[j] = array[i];
    j++;
   }
}

Console.Write (string.Join("  ", array));
Console.WriteLine();
Console.WriteLine("Элементы, длина которых меньше, либо равна 3 символам: ");
Console.Write (string.Join("  ", newArray));