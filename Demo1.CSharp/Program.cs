namespace Demo1.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables 
            // variable declaration : Location in memory used to Stored data.

            // Declare variable 
            int number; // Data type  + variable name => Allocated uninitialized 4 bytes in memory.

            //Console.WriteLine(number) // you can't use unassigned local variable

            number = 8; // Assign value 8 to number

            Console.WriteLine(number);

            // Variable : 
            // 1.Name : number
            // 2.Data type : int
            // 3.value :  8
            // 4.Size : 4 bytes : 32 bits
            // 5. Address : Hexadecimal

            //int number; // invalid variable name because we use this name in our code.

            //int number1, number2, number3; // we can declare more than variable in a single line with a single data  type
        }
    }
}
