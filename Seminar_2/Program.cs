// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа 
/*
int num = new Random().Next(10,99);
Console.WriteLine(num);
int s1 = num / 10;
int s2 = num % 10;
Console.WriteLine(s1+" "+s2);
if (s1>s2)Console.WriteLine(s1);
else Console.WriteLine(s2);
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа
/*
int num = new Random().Next(10,9999); // рандомное число
Console.WriteLine(num); // выводим на экран
int max = num%10; //берем последнюю цифру числа
while (num!=0) //пока переменная num неравна нулю
{
    int k = num%10; // берем последнюю цифру чила
    if (k>max) max=k; // если она больше к, то max равно последняя цифра числа, если k меньше - то ничего не происходит
    num = num/10; //отсекаем последнюю цифру
}
Console.WriteLine(max);
*/
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
/*
int num = new Random().Next(10,999); // Если num 123 
Console.WriteLine(num);
int result = (num/100)*10 + num % 10; // num/100 = 1 (т.к число int, а не double) первая цифра, 1*10=10, с помощью % мы находим последнюю 
//цифру числа, т.е. 10+3=13
// Console.WriteLine(result);
Console.WriteLine($"Число без второй цифры -> {result}");
*/
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2
// не кратно числу 1, то программа выводит остаток от деления.
/*
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1%number2==0)Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток равен {number1%number2}");
*/
// ВВодится строка слов, разделенных пробелами. Найти самое длинное слово и вывести его на экран. Случай, когда самых длинных слов
//может быть несколько не обрабатывать. (one, two, three, four, five, six, seven)
string s = Console.ReadLine();
string[] subs = s.Split(' '); // есть массив, слова которых разделены пробелом
int max = 0;
string max_word = subs[0]; // переменная max отвечает за самое максимальное слово
foreach (var sub in subs) // sub - слово, subs = массив, будем брать все элементы из массива subs
{
    int k = 0; // переменная отвечает за количество букв в одном слове
    foreach (var w in sub) // находим количество букв которое встречается в слове, w = буква
    {
        k++;
    }
    if (k>max){
        max_word = sub;
        max = k;
    }
}
Console.WriteLine($"{max_word}");
