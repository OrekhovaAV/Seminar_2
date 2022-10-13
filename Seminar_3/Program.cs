// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
// 1 способ
void chetvert(int x, int y) // void - не возвращаемая функция
{
    if (x > 0 && y > 0) // && - и, || - или
        Console.WriteLine("1 четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0)
        Console.WriteLine("3 четверть");
    else 
        Console.WriteLine("4 четверть");
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
chetvert(x,y);
// 2 способ
string chetvertV2(int x, int y){ // Тернарный оператор - запись условия в одну строчку, ? - истина, : иначе
    string name = x>0 && y>0 ? "1 четверть" : x>0 && y<0 ? "2 четверть" : x < 0 && y < 0 ? "3 четверть" : "4 четверть";
    return name; // Значение переменной name перешло в переменную otvet
}
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
string otvet = chetvertV2(x,y); // Вывели переменную otvet
Console.WriteLine(otvet);
*/

// Напишите программу, которая по хаданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и Y) 
// 1 способ
/*
void diapason(int a){
    if (a == 1) Console.WriteLine("x>0 и y>0");
    else if (a == 2) Console.WriteLine("x>0 и y<0");
    else if (a == 3) Console.WriteLine("x<0 и y<0");
    else Console.WriteLine("x<0 и y>0");
}
int a = int.Parse(Console.ReadLine());
diapason(a);
*/
// 2 способ
/*
string diapasonV2(int b) {
    string tochki = b == 1 ? "x>0 и y>0" : b == 2 ? "x>0 и y<0" : b == 3 ? "x<0 и y<0" : "x<0 и y>0";
    return tochki;
}
int b = int.Parse(Console.ReadLine());
string vivod = diapasonV2(b);
Console.WriteLine(vivod);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
/*
double dist (int x1, int y1, int x2, int y2){
    double res = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    return res;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
double otvet = dist(x1,y1,x2,y2);
Console.WriteLine(otvet);
*/