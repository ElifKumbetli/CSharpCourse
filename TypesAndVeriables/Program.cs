namespace TypesAndVeriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Values Types
            //Console.WriteLine("Hello, World!");
            double number5 = 10.4;
            decimal numbet6 = 10.4M;
            char character = 'A';
            bool condition = false;
            byte number4 = 255; 
            short number3 = -32768;
            int number1 = 10;
            long number2 = 2147483648;
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);


            Console.WriteLine("Character is : {0}",(int) character);
            Console.ReadLine();
        }
    }
}