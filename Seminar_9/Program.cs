// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N. С помощью рекурсии
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
int k = 0;
string FillNumbers(int n){
    if (n==1) return (k+1).ToString();
    else {
        k++;
        return (k+ " " + FillNumbers(n-1));
    }
}
// Как выглядит рекурсия
// n=5
// F(5)=5+F(4)
// F(4)=4+F(3)
// F(3)=3+F(2)
// F(2)=2+F(1)
// F(1)=1
Console.WriteLine(FillNumbers(5));
*/

/*
// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
string FillNumbers(int start, int end){
    if (end==start) return end.ToString();
    else
        return (start+" "+FillNumbers(start+1,end));
}
Console.WriteLine(FillNumbers(1,5));
*/

/*
// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int sumNumb(int n){
    if (n%10==0) return 0;
    else
        return (n%10 + sumNumb(n/10));
}
Console.WriteLine(sumNumb(453));
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
/*
int Umn(int A, int B)
{
    if (B==0) return 1;
    if (B==1) return A;
    else 
    B--;
        return (A*Umn(A,B));
}
Console.WriteLine(Umn(3, 3));
*/


// Вам дан словарь, состоящий из пар слов. Каждое слово является синонимом к парному ему слову. Все слова в словаре различны.
// Для слова из словаря, записанного в последней строке, определите его синоним.
/*
string FindDictionary(int n){
    Dictionary<string,string> dict = new Dictionary<string, string>();
    for(int i=0; i<n; i++){
        Console.Write("Ведите пары слов: ");
        string[] names = Console.ReadLine().Split();
        dict.Add(names[0],names[1]);
        dict.Add(names[1],names[0]);
    }
    Console.Write("Ведите имя: ");
    string choos_name = Console.ReadLine();
    return dict[choos_name];
}
Console.Write("Ведите число слов: ");
int kol = int.Parse(Console.ReadLine());
Console.WriteLine(FindDictionary(kol));
*/
// Задача «Выборы в США»
// Как известно, в США президент выбирается не прямым голосованием, а путем двухуровневого голосования. 
// Сначала проводятся выборы в каждом штате и определяется победитель выборов в данном штате. Затем проводятся государственные выборы: 
// на этих выборах каждый штат имеет определенное число голосов — число выборщиков от этого штата. На практике, все выборщики от штата 
// голосуют в соответствии с результами голосования внутри штата, то есть на заключительной стадии выборов в голосовании участвуют штаты, 
// имеющие различное число голосов.

// В первой строке дано количество записей. Далее, каждая запись содержит фамилию кандидата и число голосов, отданных за него в одном из штатов. 
// Подведите итоги выборов: для каждого из участника голосования определите число отданных за него голосов. Участников нужно выводить в 
// алфавитном порядке.
// 5                  Вывод:
// McCain 10         McCain 16
// McCain 5          Obama 17
// Obama 9
// Obama 8
// McCain 1
/*
void FindDictionary(int n){
    Dictionary<string,int> dict = new Dictionary<string, int>();
    for(int i=0; i<n; i++){
        Console.Write("Ведите количество штатов: ");
        string[] names = Console.ReadLine().Split();
        if (dict.ContainsKey(names[0])){
            dict[names[0]]= dict[names[0]]+int.Parse(names[1]);
        }
        else
        dict.Add(names[0],int.Parse(names[1]));
    
    }
    foreach(var item in dict){
            Console.WriteLine($"За {item.Key} проголосовало {item.Value}");
        }
}
FindDictionary(3);
*/

/*
// Задача «Самое частое слово»
// Дан текст: в первой строке задано число строк, далее идут сами строки. Выведите слово, которое в этом тексте встречается чаще всего. 
// Если таких слов несколько, выведите то, которое меньше в лексикографическом порядке.
void FindMaxString(int n){
    Dictionary<string,int> dict = new Dictionary<string, int>();
    for(int i=0; i<n; i++){
        string[] words = Console.ReadLine().Split();
        foreach(var word in words){
            if (dict.ContainsKey(word)){
                dict[word]=dict[word]+1;
            }
            else
                dict.Add(word,1);
        }
    }
    int max = 1;
    string name = String.Empty;
        foreach(var el in dict){
            if(el.Value>max){
                max=el.Value;
                name=el.Key;
            }
        Console.WriteLine($"Слово {el.Key} встретилось {el.Value}");
        }
    Console.WriteLine();
    Console.WriteLine(name);
}

Console.Write("Ведите число слов: ");
int kol = int.Parse(Console.ReadLine());
FindMaxString(kol);
*/
