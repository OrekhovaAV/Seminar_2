// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
void FillMas(int[,] arr){
    for(int i=0; i<5; i++)
        for(int j=0; j<5; j++)
            arr[i,j]= new Random().Next(2,10);
}
void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Swap(int[,] arr){
    int LastIndex = arr.GetLength(0)-1;
    for (int j=0; j<arr.GetLength(1); j++){
        int temp = arr[0,j];
        arr[0,j] = arr[LastIndex,j];
        arr[LastIndex,j] = temp;
    }
    return arr;
}
int[,] array = new int[5,5];
FillMas(array);
Output(array);
int[,] newArr = new int[5,5];
newArr = Swap(array);
Output(array);
*/

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
/*
void FillMas(int[,] arr){
    for(int i=0; i<5; i++)
        for(int j=0; j<5; j++)
            arr[i,j]= new Random().Next(2,10);
}
void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FullSwap(int[,] arr){
    int[,] rArr = new int[arr.GetLength(0),arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            rArr[j,i]=arr[i,j];
        return rArr;
}
int[,] array = new int[5,5];
FillMas(array);
Output(array);
int[,] ReversArr = new int[5,5];
Output(FullSwap(array));
*/

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// 1, 2, 3          1 встречается 3 раза 
// 4, 6, 1          2 встречается 2 раз
// 2, 1, 6          3 встречается 1 раз 
//                  4 встречается 1 раз
//                  6 встречается 2 раза

void FillMas(int[,] arr){
    for(int i=0; i<5; i++)
        for(int j=0; j<5; j++)
            arr[i,j]= new Random().Next(2,10);
}
void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FullSwap(int[,] arr){
    int[,] rArr = new int[arr.GetLength(0),arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0); i++)
        for(int j=0; j<arr.GetLength(1); j++)
            rArr[j,i]=arr[i,j];
        return rArr;
}

int[] GetArray(int[,] array){
    int[] ArrayOne = new int[array.GetLength(0)*array.GetLength(1)];// размерность 25
    int k = 0;
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++){
            ArrayOne[k] = array[i,j];
            k++;
        }

    PrintMasOne(ArrayOne);
    return ArrayOne;
}
void PrintMasOne(int[] arr){
    foreach(var el in arr){
        Console.Write(el + " ");
    }
    Console.WriteLine();
}
void SortMas(int[] array){
    for(int i=0; i<array.Length;i++){
        for(int j=i+1; j<array.Length; j++)
            if(array[i]>array[j]){
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    }
    PrintMasOne(array);
}
void FillDictionary(int[,] array){
    Dictionary<int,int> numbers = new Dictionary<int,int>();
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++){
            if(numbers.ContainsKey(array[i,j])){
                numbers[array[i,j]]+=1;
            }
            else
                numbers.Add(array[i,j],1);
        }
        foreach(var num in numbers){
            Console.WriteLine($"Число {num.Key} встретилось {num.Value}");
        }
}


int[,] array = new int[5,5];
FillMas(array);
Output(array);
int[,] ReversArr = new int[5,5];
// Output(FullSwap(array));
// int[]arr1 = GetArray(array);
// SortMas(arr1);
FillDictionary(array);


 
