namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1); // Output: Hours: 1, Minutes: 10, Seconds: 15

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2); // Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3); // Output: Minutes: 11, Seconds: 6

            //D3 = D1 + D2;
            //Console.WriteLine(D3); // Combined result

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3); // Should increase by 1 minute

            //if (D1 > D2) Console.WriteLine("D1 is greater");

            //if (D1) Console.WriteLine("D1 is true (non-zero)");

            //DateTime dt = (DateTime)D1;
            //Console.WriteLine(dt.ToLongTimeString());
            #endregion


            #region Part02

            /*
             * 2.Create an array of Employees with size three a DBA,
             * Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
             */

            Employee[] EmpArr = new Employee[3];

           //"1st employee info"

            EmpArr[0] = new Employee()
            {
                Id = 1,
                Name = "Hana",
                Salary = 10000,
                Gender = Gender.F,
                SecurityLevel = SecurityLevel.DBA,
                HireDate = new HireDate(3, 6, 2021)
            };

            //2nd employee info

            EmpArr[1] = new Employee()
            {
                Id = 2,
                Name = "Lojy",
                Salary = 10000,
                Gender = Gender.F,
                SecurityLevel = SecurityLevel.guest,
                HireDate = new HireDate(11, 3, 2022)
            };

            //3th employee info

            EmpArr[2] = new Employee()
            {
                Id = 3,
                Name = "Soty",
                Salary = 10000,
                Gender = Gender.F,
                SecurityLevel = (SecurityLevel)15,
                HireDate = new HireDate(11, 3, 2022)
            };
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
                
            }





            #endregion
        }
    }
}
