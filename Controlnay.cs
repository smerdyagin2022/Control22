/* Задача 
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина из которых меньше либо равна трем символам.
-------------------------------------------------------------------------------- */

// Вывод массива на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Формирование нового массива согласно условию задачи
void ProverkaStrok(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
    }
}
// Код программы
string[] data = { "Kentavr", "yet", "5632", "Ok", "%#2*&", "Привет", "ура", "*****", "(-)", "Тв", "МИР" };
string[] finish = new string[data.Length];
Console.WriteLine ("Наш входной массив :");
PrintArray(data);
ProverkaStrok(data, finish);
Console.WriteLine ("Отсортированный массив :");
PrintArray(finish);