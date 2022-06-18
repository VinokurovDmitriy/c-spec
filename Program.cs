//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine("Введите элементы через запятую");
string str = Console.ReadLine();
string[] strArray = str.Split(',');

void resizeArray(string[] array) //функция увеличивает массив на 1 элемент
{
    string[] newArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
}

//фильтр элементов исходного массива
string[] result = new string[0];
for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length < 4)
    {
        result = resizeArray(result);
        result[result.Length - 1] = strArray[i];
    }
}

//печать результата
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + ', ');
}