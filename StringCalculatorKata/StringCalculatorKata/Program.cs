using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringCalculator str = new StringCalculator();

             
            Console.WriteLine(str.Add(""));//0
            Console.WriteLine(str.Add("1,2"));//3
            Console.WriteLine(str.Add("1,/n2"));//3
            Console.WriteLine(str.Add("4,/n2[1"));//7
            Console.WriteLine(str.Add("4,/n2[1"));//7
            Console.WriteLine(str.Add(":1{1+1-1"));//4










            Console.ReadLine();

        }  
                
    }
}
