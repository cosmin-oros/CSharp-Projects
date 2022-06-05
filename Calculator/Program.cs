namespace Calculator{
    class Program{
        static void Main(string[] args){
            do{

            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add ");
            Console.WriteLine("\t- : Subtract ");
            Console.WriteLine("\t* : Multiply ");
            Console.WriteLine("\t/ : Divide ");

            Console.WriteLine("Enter an option: ");

            switch(Console.ReadLine()){
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
                Console.WriteLine("Would you like to continue? (Y or N)");
            }while(Console.ReadLine().ToUpper() == "Y");

            Console.ReadKey();
        }
    }
}