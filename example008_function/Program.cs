/* Задача 8.
Найти с помощью функций максимум из 9 чисел
*/
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 5;
int b1 = 6;
int c1 = 16;
int a2 = 889;
int b2 = 19;
int c2 = 42;
int a3 = 22;
int b3 = 11;
int c3 = 33;
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
