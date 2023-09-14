using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.playground
{
    public class DelegatesTutorial
    {
        public delegate void MyDelegate(string message);
        public delegate int MathOperation(int a, int b);

        public delegate void LogDel(string name, DateTime datetime);


        public static void greet(string message)
        {
            Console.WriteLine(message);
        }

        public MyDelegate del = greet;
        public LogDel logDel = new LogDel(LogTextToScreen);

        public static void LogTextToScreen(string text, DateTime dateTime)
        {
            Console.WriteLine($"{dateTime} : {text}");
        }
        public void calculateSquare(int num, out int square, out bool isGreaterThanTwenty)
        {
            square = num * num;
            isGreaterThanTwenty = square > 20;
        }

    }
}
