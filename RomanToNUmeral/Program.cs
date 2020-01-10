using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertRomanToNumeral ObjectName = new ConvertRomanToNumeral();
            while (true)
            {
                string Val = (Console.ReadLine()).ToUpper();
                if (ObjectName.ValidateRoman(Val))
                {
                    Console.WriteLine(ObjectName.RomanToNumeral(Val));
                }
                else
                {
                    Console.WriteLine("Not A Valid Roman Number");
                }
            }
        }
    }
}
