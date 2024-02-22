namespace hometaskMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(Taskk(12,34,22,55,22,101,24,55));
            //Console.WriteLine(Month(6));
            //Console.WriteLine(Task3(231));
            Console.WriteLine(Task4(40,50,20));
        }
        static int Taskk ( params int[] arry)
        {   int sum = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] >=10 && arry[i] <= 100)
                {
                    sum += arry [i];
                }
            }
            return sum;
        }
        static int Month(int a)
        {
            switch (a)
            {
                     case 1:
                    Console.WriteLine("qis");break;
                    case 2:
                    Console.WriteLine("qis"); break;
                    case 3:
                    Console.WriteLine("yaz");break;
                    case 4:
                    Console.WriteLine("yaz"); break;
                    case 5:
                    Console.WriteLine("yaz");break;
                    case 6:
                    Console.WriteLine("yay"); break;
                    case 7:
                    Console.WriteLine("yay"); break;
                    case 8:
                    Console.WriteLine("yay"); break;
                    case 9:
                    Console.WriteLine("payiz"); break;
                     case 10:
                    Console.WriteLine("paziz"); break;
                    case 11:
                    Console.WriteLine("payiz"); break;
                     case 12:
                    Console.WriteLine("qis"); break;
                     default:Console.WriteLine("duzgun eded daxil et.");break;
            }
            return a;
        }
        static int Task3 (int a ) 
        {   int result=1;
            if (a > 0)
            {
                int n = a % 10;
                result *= n;
                a /= 10;


            }
            return result;
        }
        static int Task4(int a ,int b ,int c)
        {   int sum = 0;
            if (a < b && a > c ) 
            { 
                sum += a;
            }
             if (b > a && b > c ) 
            { 
            sum += b;
            }
             if (c < a && c > b )
            {

                sum += c;
            }
            else
            {
                Console.WriteLine("duzgun ededi daxil et");
            }
            return sum;
        }
    
    
    
    
    }
}
