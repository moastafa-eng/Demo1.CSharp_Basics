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



        }
    }
}
