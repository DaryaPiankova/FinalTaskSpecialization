void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Console.ReadLine();
}

string[] NewArray(string[] array)
{

    int sz = new Random().Next(0, 4);
    string[] array2 = new string[sz];

    for (int i = 0; i < sz; i++)
    {
        array2[i] = array[new Random().Next(0, array.Length)];
    }
    return array2;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", NewArray(array))}]");