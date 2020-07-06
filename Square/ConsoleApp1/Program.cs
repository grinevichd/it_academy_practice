using System;

namespace ConsoleApp1
{
    class Program
    {
        static void UniqueItem( ref int dikrement, ref int dikremet2)
        {
            dikrement++;
            dikremet2++;
        }
            



        static void Main(string[] args)
        {
            int dikrement = 2;
            int dikrement2 = 3;
            UniqueItem(ref dikrement, ref dikrement2);
            Console.WriteLine("Из метода в маин передаются числа в методм UniqueItem ввиде 2 и 3 они повышаеются и запимываются как {3} , {4}");
            Console.WriteLine(dikrement);
            Console.WriteLine(dikrement2);
            
        }
    }
}
