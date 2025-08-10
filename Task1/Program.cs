namespace Task01
{
    internal class Program
    {

        //static int LongestDistance(int[] arr)
        //{
        //    int maxDistance = 0;

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = arr.Length - 1; j > i; j--)
        //        {
        //            if (arr[i] == arr[j])
        //            {
        //                int distance = j - i - 1;
        //                if (distance > maxDistance)
        //                {
        //                    maxDistance = distance;
        //                }
        //                break;
        //            }
        //        }
        //    }

        //    return maxDistance;
        //}
        static void Main(string[] args)
        {
            #region Q01

            //int num;
            //bool flag = int.TryParse(Console.ReadLine(),out num);

            //if (flag)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter an integer.");
            //}
            #endregion

            #region Q02

            //char c;
            //bool isValidChar = char.TryParse(Console.ReadLine(), out c);

            //if (isValidChar) {

            //    switch (c) {
            //        case 'a':
            //        case 'e':
            //        case 'i':
            //        case 'o':
            //        case 'u':
            //            Console.WriteLine("It's a vowel");
            //            break;
            //        default:
            //            Console.WriteLine("It's a consonant");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a character.");
            //}

            #endregion

            #region Q03

            //int monthNumber;

            //bool flag=int.TryParse(Console.ReadLine(), out monthNumber);

            //if (flag) {

            //    switch (monthNumber)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("31 days");
            //            break;
            //        case 2:
            //            Console.WriteLine("28 or 29 days");
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("30 days");
            //            break;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid month number.");
            //}



            #endregion

            #region Q04

            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            // if (flag)
            //{
            //    Console.WriteLine("First way");
            //    for (int i = 1; i <= num; i++)
            //        Console.WriteLine(i);
            //    Console.WriteLine("Second way");
            //    for (int i = num; i >= 1; i--)
            //        Console.WriteLine(i);

            //}


            #endregion

            #region Q05


            //int baseNum, exponentNum;

            //bool isBaseValid = int.TryParse(Console.ReadLine(), out baseNum);
            //if (isBaseValid) {
            //    bool isExponentValid = int.TryParse(Console.ReadLine(), out exponentNum);
            //    if (isExponentValid && exponentNum >= 0)
            //    {
            //        int result = 1;
            //        for (int i = 0; i < exponentNum; i++)
            //        {
            //            result *= baseNum;
            //        }
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for exponent. Please enter a non-negative integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for base. Please enter a positive integer.");
            //}


            #endregion

            #region Q06

            //string input = Console.ReadLine()!;
            //if (input is not null)
            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(input[i]);
            //    }
            //else {
            //    Console.WriteLine("Pls,enter valid string");
            //}
            #endregion

            #region Q07


            //int num;

            //bool flag = int.TryParse(Console.ReadLine(), out num);

            //if (flag) {
            //    int[,] indenMatrix = new int[num, num];
            //    for (int i = 0; i < num; i++)
            //    {
            //        for (int j = 0; j < num; j++)
            //        {
            //            if (i == j)
            //            {
            //                indenMatrix[i, j] = 1;
            //            }
            //            else
            //            {
            //                indenMatrix[i, j] = 0;
            //            }
            //        }
            //    }
            //    for (int i = 0; i < num; i++)
            //    {
            //        for (int j = 0; j < num; j++)
            //        {
            //            Console.Write(indenMatrix[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Q08

            //int[] arr = [5,8,0,10,9,1];

            //int maxNum= int.MinValue;
            //int minNum = int.MaxValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > maxNum)
            //    {
            //        maxNum = arr[i];
            //    }
            //    if (arr[i] < minNum)
            //    {
            //        minNum = arr[i];
            //    }
            //}

            //Console.WriteLine($"the max number in the array is:{maxNum}\n the min number of an array is: {minNum}");

            #endregion

            #region Q09

            //Console.WriteLine("Enter array elements separated by spaces:");
            //string input = Console.ReadLine();
            //int[] arr = Array.ConvertAll(input.Split(), int.Parse);

            //int result = LongestDistance(arr);
            //Console.WriteLine($"The longest distance between two equal values is: {result}");
            #endregion

            #region Q10

            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Hana",
            //    Permissions = Permissions.Read 
            //};

            //Permissions permissions;
            //bool flag= Enum.TryParse(Console.ReadLine(), true, out permissions);
            //if (flag)
            //{
            //    if ((student.Permissions & permissions) == permissions)
            //    {
            //        Console.WriteLine("Student already has this permission.");
            //    }
            //    else
            //    {
            //        student.Permissions |= permissions;
            //        Console.WriteLine("Permission added.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid permission input");
            //}
            #endregion

            #region Q11

            //Colors color = new Colors();

            //bool flag = Enum.TryParse(Console.ReadLine(), true, out color);

            //if (flag) {
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            break;

            //    }
            //}

            //else
            //{
            //    Console.WriteLine($"{color} is not a primary color.");
            //}
            #endregion

            #region Q12

            //Person person1 = new Person();
            //Person person2 = new Person();
            //Person person3 = new Person();

            //Console.WriteLine("Enter details for Person 1:");
            //person1.Name = Console.ReadLine();

            //int age;

            //bool flag=int.TryParse(Console.ReadLine(), out age);

            //if (flag)
            //{
            //    person1.Age = age;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for age. Please enter a valid integer.");
            //}

            //Console.WriteLine("Enter details for Person 2:");
            //person1.Name = Console.ReadLine();

            //int age2;

            // flag = int.TryParse(Console.ReadLine(), out age2);

            //if (flag)
            //{
            //    person2.Age = age2;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for age. Please enter a valid integer.");
            //}

            //Console.WriteLine("Enter details for Person 3:");
            //person3.Name = Console.ReadLine() ?? "No name";

            //int age3;

            // flag = int.TryParse(Console.ReadLine(), out age3);

            //if (flag)
            //{
            //    person3.Age = age3;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for age. Please enter a valid integer.");
            //}

            //Person.GetOldestPerson(person1, person2, person3);







            #endregion
        }
    }
}
