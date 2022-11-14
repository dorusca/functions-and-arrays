/* Присвоение индексу другое число:
int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
    if ( arg2 >result ) result= arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int []array = {11,45,33,54,67,32,89,34,99};
array[0] = 55;          //присвоили индексу [0] число 55, было 11


Console.WriteLine(array[0]);

Поиск максимального числа с помощью масива: */

int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
    if ( arg2 >result ) result= arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int []array = {11,45,33,54,67,32,890,34,99};
int max = Max (
    Max (array [0], array [1],array [2]),
    Max (array [3],array [4], array [5]),
    Max (array [6], array [7], array [8]));
Console.WriteLine (max);