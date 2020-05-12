using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace try_github
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("2桁の数値を入力し、足し算と引き算を行うプログラム");
            Console.Write("値を入力してください\na：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("　b:");
            int b = int.Parse(Console.ReadLine());
            int total, total2;
            total = Add.add(a, b);
            total2 = Sub.sub(a, b);
            Console.WriteLine("計算結果\n足し算：" + total +"\n引き算："+ total2 );

        }
    }
}
