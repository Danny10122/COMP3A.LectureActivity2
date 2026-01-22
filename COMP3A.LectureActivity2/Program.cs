namespace COMP3A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            string input1 = Console.ReadLine();
            Console.Write("Emter the second number:");
            string input2 = Console.ReadLine();

            //For the sum and avg
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);

            double sum = num1 + num2;
            double average = sum / 2;
            
            //Using Concatenations table
            Console.WriteLine("\nUsing Concatenation");
            Console.WriteLine("Sum: " +sum);
            Console.WriteLine("Average:" + average);

            //Using Interpolation
            Console.WriteLine("\nUsing Interpolation");
            Console.WriteLine($"Sum: {sum}" );
            Console.WriteLine($"Average: {average}");

            //Comparsions
            Console.WriteLine("\nComparisons");
            Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
            Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
           



        }
    }
}
