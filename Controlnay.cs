/* ������ 
�������� ���������, ������� �� ���������� ������� ����� ��������� ������ �� �����,
����� �� ������� ������ ���� ����� ���� ��������.
-------------------------------------------------------------------------------- */

// ����� ������� �� �����
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// ������������ ������ ������� �������� ������� ������
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
// ��� ���������
string[] data = { "Kentavr", "yet", "5632", "Ok", "%#2*&", "������", "���", "*****", "(-)", "��", "���" };
string[] finish = new string[data.Length];
Console.WriteLine ("��� ������� ������ :");
PrintArray(data);
ProverkaStrok(data, finish);
Console.WriteLine ("��������������� ������ :");
PrintArray(finish);