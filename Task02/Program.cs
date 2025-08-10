namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1); // Output: Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2); // Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3); // Output: Minutes: 11, Seconds: 6

            D3 = D1 + D2;
            Console.WriteLine(D3); // Combined result

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3); // Should increase by 1 minute

            if (D1 > D2) Console.WriteLine("D1 is greater");

            if (D1) Console.WriteLine("D1 is true (non-zero)");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt.ToLongTimeString());
            #endregion
        }
    }
}
