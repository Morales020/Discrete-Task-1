using System.Globalization;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Start Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The End Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Numbers Between {0} And {1} is : ",num1,num2);

            for (int i = num1;i<= num2;i++)
            {
                int counter = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
            if (counter==0 && i >1)
                    {
                       Console.WriteLine( i );
                    }
            }
        }
    }
}