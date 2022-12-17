using static System.Console;
int Max(int a, int b, int c)
{
    int rez = a;
    if (b > a) {rez = b;}
    if (c > rez) {rez = c;}
    return rez;
}
int a1 = 7;
int a2 = 29;
int a3 = 3;
int a4= 12;
int a5 = 11;
int a6 = 47;
int a7 = 23;
int a8 = 12;
int a9 = 15;


int max = Max(Max(a1 ,a2, a3), Max(a4 ,a5, a6), Max(a7 ,a8, a9));
Write(max);
