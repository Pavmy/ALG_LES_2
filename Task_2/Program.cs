using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//2. Реализовать функцию возведения числа a в степень b:

//a.без рекурсии;
//long powmod(long a, long K, long n)
//{
//    long A = a, b = 1, i, k[32];
//    long t = long_to_binary(K, k);

//    if (K == 0) return b;
//    if (k[0] == 1) b = a;

//# ifdef DEBUG
//    printf("-------------\n");
//    printf("i k   A    B \n");
//    printf("-------------\n");
//    printf("%ld %ld %4ld %4ld\n", i = 0, k[i], A, b);
//#endif

//    for (i = 1; i < t; i++)
//    {
//        A = (A * A) % n;
//        if (k[i]) b = (A * b) % n;
//# ifdef DEBUG
//        printf("%ld %ld %4ld %4ld\n", i, k[i], A, b);
//#endif
//    }

//# ifdef DEBUG
//    printf("-------------\n");
//#endif

//    return b;
//}

//int main(void)
//{

//    long a = 5, K = 596, n = 1234;

//    printf("%ld\n", powmod(a, K, n));

//    return 0;
//}

//b.рекурсивно;
//int n_pow(int a, int n)
//{
//    return (n > 0) ? a * n_pow(a, n - 1) : 1;
//}

//c. * рекурсивно, используя свойство чётности степени.


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.5;
            int stepen = 4;
            Console.WriteLine("0.5^4 = " + Math.Pow(x, stepen));
            Console.WriteLine("5^4 = " + Math.Pow(5, 4));
            Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
            Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));
            Console.ReadKey();
        }
    }
}
