string[] array1 = new string[] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "GB"};
string[] array2 = new string[array1.Length];
int count = 0;
FillArray(array1, array2);

void FillArray(string[] array1, string[] array2)
{
for (int i = 0; i < array1.Length; i++)
{
if (array1[i].Length <= 3)
{
array2[count] = array1[i];
count++;
}
}
Array.Resize(ref array2, count);
PrintArray(array1,array2);
}

void PrintArray(string[] startArray, string[] array)
{

Console.WriteLine("[{0}]", string.Join(", ", startArray));
Console.Write(" -> [{0}]", string.Join(", ", array));

}
