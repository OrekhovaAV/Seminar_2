// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4. 
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); // *5 рандомные числа до 5.
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран. 
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); // *5 рандомные числа до 5.
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Zapolnenie(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++)
            mylist[i][j]=i+j;
        }
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);
*/

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:        Новый массив будет выглядеть вот так:
//             1 4 7 2                                              1 4 7 2       
//             5 9 2 3                                              5 81 2 9
//             8 4 2 4                                              8 4 2 4
/*
void FillList(List <List<double>> mylist){ // Генерация двумерного массива
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); // *5 рандомные числа до 5.
        }
}
void PrintList(List <List<double>> mylist){ // вывод массива на экран
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Zapolnenie(List <List<double>> mylist){ // решение задачи
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++)
           if (i%2==0 && j%2==0)
            mylist[i][j] = Math.Pow(mylist[i][j],2);
        }
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
PrintList(numbers);
*/

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); 
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double Zapolnenie(List <List<double>> mylist){
    double sum = 0;
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++)
            if (i==j)
                sum+=mylist[i][j];
        }
    return sum;
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Console.WriteLine(Zapolnenie(numbers));
PrintList(numbers);
*/

// Задача «Поменять столбцы». Дан двумерный массив и два числа: i и j. Поменяйте в массиве столбцы с номерами i и j и выведите результат.
// Программа получает на вход размеры массива n и m, затем элементы массива, затем числа i и j.
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); 
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double Zapolnenie(List <List<double>> mylist){
    double sum = 0;
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++)
            if (i==j)
                sum+=mylist[i][j];
        }
    return sum;
}
void Swap(List <List<double>> mylist, int j1, int j2){
    double temp = 0;
    for (int i=0; i<mylist.Count;i++)
        for (int j=0;j<mylist[i].Count;j++){
           temp = mylist[i][j1];
            mylist[i][j1] = mylist[i][j2];
            mylist[i][j2] = temp; 
        }
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Swap(numbers, 1, 3);
PrintList(numbers);
*/

// По данным числам n и m заполните двумерный массив размером n×m числами от 1 до n×m “змейкой”, как показано в примере. Вводятся два 
// числа n и m. Чтобы сделать такой большой отступ можно использовать \t.
// Пример:
// 1 2 3 4 5
// 6 7 8 9 10
// 11 12 13 14 15
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); 
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double Zapolnenie(List <List<double>> mylist){
    double sum = 0;
    double count = 1;
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++){
           mylist[i][j] = count;
           count++;
        }
    }
    return sum;
}

List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Console.WriteLine(Zapolnenie(numbers));
PrintList(numbers);
*/