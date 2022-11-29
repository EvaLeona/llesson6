int[] myArray = InputArray();
Console.WriteLine($"{ArrayToString(myArray)} -> {GetPisitiveCount(myArray)}");

int GetPisitiveCount(int[] array) 
{
    int count = 0;
    foreach (int item in array) { if (item > 0) count++; }
    return count;
}

int[] InputArray() 
{
    Console.Write("Введите массив из N чисел, разделяя запятыми: ");
    string[] numbers = Console.ReadLine()!.Trim(' ',',').Split(",");
    int[] array = new int[numbers.Length];
    int i = 0;
    foreach (var item in numbers)
    {
        array[i] = Convert.ToInt32(item); i++;
    }
    return array;
}
String ArrayToString(int[] array) { return "[" + String.Join(", ", array) + "]"; }