// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// int  [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int FindPosSumm(int [] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0)
//             summ += array[i];
//     }
//     return summ;
// }

// int FindNegSumm(int [] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]<0)
//             summ += array[i];
//     }
//     return summ;
// }

// int size = 12;
// int min = -9;
// int max = 9;
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Summ of positive numbers is {FindPosSumm(array)}");
// Console.WriteLine($"Summ of negative numbers is {FindNegSumm(array)}");







// 1. Напишите программу замены элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// int  [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }


// void ShowArray(int [] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// int Reverse(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array [i] = array[i] * (-1);
//     }
//     return array [];
// }

// Console.Write("Введите длину масcива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// Reverse (array);







// 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве.

int  [] CreateArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}


void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool FindNumber(int [] array, int N)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == N)
            flag = true;
    }
    return flag;
}

int size = 12;
int min = -9;
int max = 9;
int N = 6;
int [] array = CreateArray(size, min, max);
ShowArray(array);
bool flag = FindNumber(array, N);
if(flag) Console.Write("yes");
else Console.Write("No");
