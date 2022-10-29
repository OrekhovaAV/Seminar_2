// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45->101101
/*
int number_1 = int.Parse(Console.ReadLine());
string number_3 = Convert.ToString(number_1,8); // в этом случае 2 - система счисления. есть 2,8,16,32
Console.WriteLine(number_3);
*/

/*
int number = int.Parse(Console.ReadLine());
int osn = 16;
string number_2 = Convert.ToString(number,osn); // в этом случае 2 - система счисления. есть 2,8,16,32
Console.WriteLine(number_2);
Console.WriteLine(perevod(number,osn));
string perevod(int number, int osn){
    string res = "";
    string nums = "0123456789ABCDEF"; // нужно для универсальности, должна передавать не одну систему счисления. в нашем случае передает 2,8,16
    while(number>0){
        int del = number/osn;// 45/2 = 22
        res = nums[number-del*osn]+res; // 45/2 = 22 - остаток 1
        number/=osn; // number = number/osn
    }
    return res;
}
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if(a+b>c && a+c>b && b+c>a) {
    Console.WriteLine("Да");
       }
else Console.WriteLine("Нет");
*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например: Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1
/*
int N = int.Parse(Console.ReadLine());
int first = 0;
int second = 1;
Console.Write(first + " " + second + " ");
for(int i=3; i<=N; i++){
    int next = first + second;
    Console.Write(next+" ");
    first = second;
    second = next;
}
*/

// Задача «Снежинка». Дано нечетное число n. Создайте двумерный массив из n×n элементов, заполнив его символами "." (каждый элемент массива 
// является строкой из одного символа). Затем заполните символами "*" среднюю строку массива, средний столбец массива, главную диагональ и 
// побочную диагональ. В результате единицы в массиве должны образовывать изображение звездочки. Выведите полученный массив на экран, разделяя 
// элементы массива пробелами.
/*
int[,] array = new int[21,21];
int n = array.GetLength(0);
void PrintArray()
{
    for(int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            if(i==j || i==n-1-j || i==n/2 || j==n/2){
                Console.Write("*");
            }
            else {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
}
PrintArray();
*/
