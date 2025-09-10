using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PuzyrevIV.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.PuzyrevIV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessege("Иван"));
            Console.ReadKey();
        }
    }
}
