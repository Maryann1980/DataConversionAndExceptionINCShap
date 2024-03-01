namespace DataConversionAndExceptionINCShap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Conversion and Exception in C#");
            Console.WriteLine();

            Input: while (true)
            {
                try
                {
                    Rectangle myrec = new Rectangle();
                    Console.WriteLine("Enter the length : ");
                    myrec.SetLength(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine();

                    Console.WriteLine("Enter the width : ");
                    myrec.SetWidth(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("The Area of the rectangle is : {0}", myrec.Area());

                    int MyArea = (int)myrec.Area(); //converted from double to int
                    Console.WriteLine("The area after converting to int is : {0}", MyArea);

                    Console.WriteLine("Boxing Output");
                    object boxedOutput = MyArea;
                    Console.WriteLine("This is boxing return : {0}", boxedOutput);

                    int unboxedOutput = (int)boxedOutput;
                    Console.WriteLine("The unboxed value is : {0}", unboxedOutput);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
