namespace Demo1.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //// variables 
            //// variable declaration : Location in memory used to Stored data.

            //// Declare variable 
            //int number; // Data type  + variable name => Allocated uninitialized 4 bytes in memory.

            ////Console.WriteLine(number) // you can't use unassigned local variable

            //number = 8; // Assign value 8 to number

            //Console.WriteLine(number);

            //// Variable : 
            //// 1.Name : number
            //// 2.Data type : int
            //// 3.value :  8
            //// 4.Size : 4 bytes : 32 bits
            //// 5. Address : Hexadecimal

            ////int number; // invalid variable name because we use this name in our code.

            ////int number1, number2, number3; // we can declare more than variable in a single line with a single data  type 
            #endregion

            #region CTS & CLS
            // CTS : Common type system
            // CLS : Common language specification

            //CLS :  expresses the common characteristics between languages ​​and each other.
            // CTS : Contains all languages, data types and CLS (Container of .Net system) 
            #endregion

            #region Value type-stack
            //// Value type - Stack
            //int number; // Allocate  UnInitialzed 4 bytes in stack.

            ////Console.WriteLine(number); // Invalid (Unassigned variable)

            //number = 10;

            //Console.WriteLine(number); // valid(Assigned variable)

            //// int : C# Keyword

            //// int32 : BCL Keyword

            //Int32 number2 = 12;

            //Console.WriteLine(number2);

            //// The most common used is C# keyWords 
            #endregion

            #region Reference type-heap
            //Point point;
            //// Declare to reference from data type point in stack
            //// Can refer to instance from type Point in Heap.
            //// P1 : refer to null.
            //// 8 bytes will be allocated in stack to the reference

            ////Console.WriteLine(point.X); // Invalid

            //point = new Point();
            //// new : 
            //// 1. Allocate the number of required bytes to the instance (point) in heap memory
            //// 2. Initialized the data type in the instance with the default values.
            //// 3. Call User_Definded constructor if exist
            //// 4. Assigned object Address or instance address to point variable in stack

            //Console.WriteLine(point.x); // 0;
            //Console.WriteLine(point.y); // 0;

            //point.x = 12;

            //Console.WriteLine(point); // 12

            //Point point2 = new Point();

            //Console.WriteLine(point2.x); // 0
            //Console.WriteLine(point2.y); // 0

            //point2 = point;

            //Console.WriteLine(point2.x); // 12 
            #endregion


            #region The parent class - object
            //// object is a reference type
            //// object is a parent of all classes

            //object x = 12;
            //object y = 1.2;
            //object j = "Mostafa";
            //object d = 'e';

            //Point p = new Point();

            //Console.WriteLine(p.ToString()); // Demo1.CSharp.Point
            //Console.WriteLine(p.GetType()); // Demo1.CSharp.Point
            //Console.WriteLine(p.GetHashCode()); // 234234
            ////Console.WriteLine(p.Equals()); 
            #endregion

            #region Explicit & Implicit Casting.
            //// Casting : Convert Data type to another data type
            //// 1. Implicit casting

            ////int x = 12;
            ////long y = /*(long)*/ x; // Automatic casting / implicitly casting
            ////// (long) : Casting operator

            ////Console.WriteLine(y);

            ////int j = 12;
            ////double n = j; // safe casting / implicitly casting

            //// 2. Explicit casting

            //long x = 10000000;
            ////int u = y; // this casting unsafe because long is bigger than int;

            //int u = (int)x; // Forcing compiler to casting between those variables / Explicitly casting

            //Console.WriteLine(u); 
            #endregion

            #region Parse & TryParse & Convert
            // parse : convert string to any data type

            //int Age;

            //Console.WriteLine("Enter your age : ");
            //Age = int.Parse(Console.ReadLine());


            // Convert : it contains many functions used in casting operation

            //int age;

            //Console.WriteLine("Enter your age : ");

            //age = Convert.ToInt32(Console.ReadLine());

            // TryParse

            //int age;

            //Console.WriteLine("Enter your age :");

            //bool flag = int.TryParse(Console.ReadLine(), out age); // return bool

            //Console.WriteLine($"your age is {age} and the flag is : {flag}"); 
            #endregion

            #region Operators

            // 1.Unary Operators -> works on one operand variable ++ --
            //int x = 10;

            // PreFix.
            //Console.WriteLine(++x); // Increment then print.

            // PostFix
            //Console.WriteLine(x++); // Print then increment.


            // PreFix.
            //Console.WriteLine(--x); // Decrement then print.

            // PostFix
            //Console.WriteLine(x--); // Print then Decrement.


            //==========================================================

            // 2.Binary operators : Works between two operand (variables)

            //int mul, sub, sum, mod;
            //int number1 = 12, number2 = 13;

            //sum = number1 + number2;
            //sub = number1 - number2;
            //mul = number1 * number2;
            //mod = number1 % number2;

            //==========================================================

            // 3.Assignment operator

            //int x = 3;

            //x += 2; // x + 2;
            //x -= 2; // x - 2;
            //x *= 2; // x * 2;
            //x /= 2;
            //x %= 2;

            //==========================================================

            // 4.Relational Operators [Comparison]

            //int x = 12, y = 13;

            //bool flag = x == y;
            //bool flag2 = x <= y;
            //bool flag3 = x >= y;
            //bool flag4 = x != y;
            //bool flag5 = x < y;
            //bool flag6 = x > y;


            //==============================================

            // 5.Logical operators [Logic gates - And, Or, Not]

            /*     Console.WriteLine(!false); // True.
                 Console.WriteLine(false && true); // false short Circuit
                 Console.WriteLine(false || true); // true short circuit*/

            //==============================================

            // 6.Bitwise operator

            //Console.WriteLine(!false);
            //Console.WriteLine(false & true); // Long circuit.
            //Console.WriteLine(false | true); // long circuit.

            // ==============================================

            // 7. Ternary operators [Conditional operators]

            //string result = (3 > 2) ? "True" : "False";

            //Console.WriteLine(result);

            #endregion
        }
    }
}
