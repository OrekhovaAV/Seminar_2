// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А. 7->28
/*
int A = int.Parse(Console.ReadLine());
int sum = 0;
for(int i=0; i<A+1; i++)
{
    sum+=i;
}
Console.WriteLine($"Сумма равна {sum}");
*/

//Задан список фамилий брокеров товарной биржи из N человек. Обменяйте местами фамили брокеров: первого и последнего,
// второго и предпоследнего, третьего от начала и третьего от конца и т.д.
// Например, Олег Вася Камила Дора -> Дора Камила Вася Олег
/*
void Vivod(string[] arr){
    foreach (var i in arr)
        Console.Write(i+" ");
    Console.WriteLine();
}
string[] Perestanovka(string[] arr){
    for(int i=0; i<arr.Length/2; i++){
        string t = arr[i];
        arr[i]=arr[arr.Length-i-1];
        arr[arr.Length-i-1]= t;
    }
    return arr;
}
int N = int.Parse(Console.ReadLine());
string[] names = new string[N];
for(int i=0; i<N; i++){
    names[i]=Console.ReadLine();
}
Vivod(names);
Perestanovka(names);
Vivod(names);
*/

// Дан одномерный массив целых чисел. Найдите сколько раз в нем повторяется самое частое число.
// Например: 15, 23, 14, 23, 17, 23, 21, 14 -> 3
/*
int[] CreateMas(int n){ // 1 функция создает массив
    int[] arr = new int[n];
    for(int i=0; i<n; i++)
        arr[i]=new Random().Next(2,10);
    return arr;
}
void Print(int[] arr){   // выводит массив
    Console.WriteLine(String.Join(" ", arr));
}
int kolichestvo(int[] arr){ // считает само количество и возвращает его для того, чтобы потом распечатать
    int k = 0;
    int max = 0;
    for(int i=0;i<arr.Length;i++){
        k=1;
        for(int j=i+1;j<arr.Length;j++){
            if(arr[i]==arr[j])k++;
        }
        if (k>max){
            max=k;
        }
    }
    return max;
}
Console.WriteLine("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
array = CreateMas(n);
Print(array);
Console.WriteLine(kolichestvo(array));
*/

// Программа должна создать массив из 12 случайных целых чисел из отрезка [-10;10] таким образом, чтобы отрицательных
// положительных элементов там было поровну и не было нулей. При этом порядок следования элементов должен быть случаен 
//(т.е. не подходит вариант, когда в массивп постоянно выпадает сначала 6 положительных, а потом 6 отрицательных чисел 
// или же когда элементы постоянно чередуются через один и пр.). Вывести полученных массив на экран.

int[] CreateMas(){
    int kol = 12;
    int[] arr = new int[12];
    int kol_pol = 0;
    int kol_otrc = 0;
    while (kol_pol!=6 && kol_otrc!=6){
        kol_pol = 0;
        kol_otrc = 0;
            for(int i=0; i<kol; i++){
                arr[i] = new Random().Next(-10,10);
                if (arr[i]>0) kol_pol++;
                else if (arr[i]<0) kol_otrc++;
                else i--;
        }
    }
    Console.WriteLine(kol_pol); 
    Console.WriteLine(kol_otrc); 
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ", arr));
}
int[] arr = new int[12];
arr = CreateMas();
Print(arr);