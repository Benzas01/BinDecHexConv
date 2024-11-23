using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BinDecHex_Conv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string com;
            string number;
            Console.WriteLine("Please enter the conversion parameters: ");
            Console.WriteLine("BTD for binary to decimal, DTC for decimal to binary");
            Console.WriteLine("HTD for hexadecimal to decimal");
            com = Console.ReadLine();
            switch (com)
            {
                case "BTD":
                    Console.WriteLine("Please enter the number in binary: ");
                    number = Console.ReadLine();
                    Console.Write("The output is: ");
                    Console.Write(Binary.ConvertToDec(number));
                    break;
                case "DTC":
                    Console.WriteLine("Please enter the number in decimal: ");
                    number = Console.ReadLine();
                    Console.Write("The output is: ");
                    Console.Write(Binary.ConverToBin(number));
                    break;
                case "HTD":
                    Console.WriteLine("Please enter the number in hexadecimal: ");
                    number = Console.ReadLine();
                    Console.Write("The output is: ");
                    Console.Write(Hexadecimal.ConvertToDec(number));
                    break;
                default:
                    Console.WriteLine("Incorrect input!!!";
                    break;
            }
        }
    }
}
