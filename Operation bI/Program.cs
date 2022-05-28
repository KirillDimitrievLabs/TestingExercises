using System;
using System.Globalization;
//В начале задания выводилось сконкатенированная строка состоящая из 2-х чисел например:
//input:
//  someValue1 = 123
//  someValue2 = 456
//output:
//  "123456"
class Program
{
    class Number
    {
        readonly object _number;

        public Number(object number)
        {
            _number = number;
        }
        public override string? ToString()
        {
            if (_number != null)
            {
                return _number.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
    static void Main(string[] args)
    {
        
        string someValue1 = "lorem ipsum ";
        double someValue2 = 5123123;

        string result = new Number(someValue1) + someValue2.ToString();
        Console.WriteLine(result);
        Console.ReadKey();
    }
}