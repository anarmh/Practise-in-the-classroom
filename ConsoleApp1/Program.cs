using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] arr3 = new int[] { 12, 3, 2 };

            //int[] arr2 = new int[7];
            //arr2[0]= 2;
            //arr2[1] = 3;
            //arr2[2] = 4;
            //Array.Resize(ref arr2, 20);
            //arr2[8] = 9;
            //int[] arr1 = { 85, 6, 3, 4, 5 };
            //Array.Reverse(arr1);
            //Array.Sort(arr1);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //int[,] arr = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } };
            //Console.WriteLine(arr.Rank);
            //int a = 6;
            //Console.WriteLine(a.GetType());
            #endregion


            string name1 = "Anar";
            string surname1 = "Huseynov";
            int age1 = 35;
            bool Ismarried = true;

            string name2 = "Cavid";
            string surname2 = "Rzayev";
            int age2 = 28;
            bool Ismarried2 = true;

            string name3 = "Kenan";
            string surname3 = "Memmedov";
            int age3 = 35;
            bool Ismarried3 = false;
            string married = Ismarried ? "evlidir" : "Subaydir";
            //Console.WriteLine($"{ name1} {surname1} {age1} {married}");


            var employee1 = new
            {
                name = "Anar",
                surname = "Huseynov",
                age1=29,
            };
            var employee2 = new
            {
                name = "Cavid",
                surname = "Rzayev",
                age2 = 28,
            };
            //Console.WriteLine($"{ employee1.name} {employee1.surname} {employee1.age1}");

            //DecimalToBinary();
            //Animal animal1 = new Animal("cat");
            //Console.WriteLine( animal1.name);

            //Calculator calculator1 = new Calculator();
            //Console.WriteLine(calculator1.Calculation());

            Employee emp1 = new Employee(false);
           
        }
        

        
        static void DecimalToBinary()
        {
            string result = " ";
            int n, r;
            Console.WriteLine("Enter the decimal number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = n % 2;
                result = Convert.ToString(r) + result;
                n = n / 2;
            }
            Console.WriteLine("Binary equivalent{0}", result);
        }

    }
}
