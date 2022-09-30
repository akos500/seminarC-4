/*
Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на 
экран. Элементы массива вводятся пользователем    
*/

Console.Write("Введите количество элементов массива:\t ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");

for (int i = 0; i < myArray.Length; i++)

{
    Console.WriteLine(myArray[i]);
}
