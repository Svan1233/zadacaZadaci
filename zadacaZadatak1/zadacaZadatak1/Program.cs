using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacaZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            int x;
            float y;

            x = a / b;
            y = a % b;

            Console.WriteLine(a+" podjeljeno sa "+b+" je "+x+" a ostatak je "+y);
            Console.ReadKey();
        }
    }
}
