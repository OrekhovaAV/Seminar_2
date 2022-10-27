// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 
/*
int[] CreateMas(int n){
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
        arr[i] = new Random().Next(2,10);
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}
int[] Zamena(int[] arr){
    for (int i=0; i<arr.Length; i++)
        arr[i]=-arr[i];
    return arr;
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
Zamena(array);
Print(array);
*/

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
/*
int[] CreateMas(int n){
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
        arr[i] = new Random().Next(2,10);
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}
int[] Zamena(int[] arr){
    for (int i=0; i<arr.Length; i++)
        arr[i]=-arr[i];
    return arr;
}
void Poisk(int[] arr, int k){
    bool f = false;
    for(int i = 0; i < arr.Length; i++)
        if (arr[i]==k){
            f = true;
            break;
        }
    if (f)
        Console.WriteLine("Нет, не найден!");
    else 
        Console.WriteLine("Да, найден!");
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
Zamena(array);
Print(array);
List<int> numbers = new List<int>();
numbers.AddRange(array);
bool b = numbers.Contains(-5);
Console.WriteLine(b);
Poisk(array, 5);
*/

/*
Задача «Кегельбан»
Условие
N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду бросили K шаров, 
при этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте.
Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 
1≤ li≤ ri≤ N.
Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, 
или “.”, если j-я кегля была сбита.
*/
