// Нахождение максимального числа из девяти с использованием функций

/*int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
    if ( arg2 >result ) result= arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 50;
int c1 = 34;
int a2 = 444;
int b2 = 56;
int c2 = 40;
int a3 = 99;
int b3 = 100;
int c3 = 77;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = c;

int max = Max (max1, max2, max3);
Console. WriteLine(max);

можно сократить запись:*/


int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
    if ( arg2 >result ) result= arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 50;
int c1 = 34;
int a2 = 9444;
int b2 = 56;
int c2 = 40;
int a3 = 99;
int b3 = 100;
int c3 = 77;

int max = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3));
Console. WriteLine(max);








