// Задача: Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find.


// Пример №1.

/*int [] array = {1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1
    index++;
}
*/


// Пример №2. 

/*int [] array = {1, 12, 31, 4, 18, 16, 17, 18 };

int n = array.Length;
int find = 18; // Два одинаковых числа в массиве.

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1
    index++;
}
*/

//Пример №3.

/*int [] array = {1, 12, 31, 4, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // добавили break, чтобы найти только первое число 18.
    }
    //index = index + 1
    index++;
}
*/