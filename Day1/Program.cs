//using System;
using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region namespace
            //LibrarySystem.Book b = new LibrarySystem.Book();
            //FlightSystem.Book fl = new FlightSystem.Book();
            #endregion

            #region Variables & Datatypes
            //Console.WriteLine("Hey R2");

            //int a = null;
            //int? a = null;
            //Nullable<int> a = null;

            //int a = "ali";
            //int a = 1000000000000;
            //a.SubString()
            //int a = 5;
            //Console.WriteLine(a);
            #endregion

            #region reading input
            //int x = Console.Read();
            //Console.WriteLine(x);

            //string? str = Console.ReadLine();
            //string str = Console.ReadLine()!;
            //Console.WriteLine(str);
            //ConsoleKeyInfo c =  Console.ReadKey();
            //Console.WriteLine(c.Key);
            #endregion

            #region Formatting Output
            //int id = 5;
            //string fname = "youssef";
            //string lname = "ali";

            // 1. string concatination
            //Console.WriteLine("id = " + id + ", fname = " + fname);

            // 2. String Holders
            //Console.WriteLine("id = {0}, fname = {1}", id, fname);
            //Console.WriteLine("id = {0}, fname = {1}", id, fname, lname);
            //Console.WriteLine("id = {0}, fname = {2}", id, fname, lname);

            // 3. String Interpolated
            //Console.WriteLine($"Id = {id}, Fname = {fname}, Lname = {lname}");
            #endregion

            #region Escape Sequences
            //int id = 5;
            //string name = "Abdelrahman Ahmed";

            // \t , \n
            //Console.WriteLine($"id={id}\t name={name}\tinstructor=men3m");
            //Console.WriteLine($"id={id, 16} name={name, 32} instructor=men3m");
            //Console.WriteLine($"id={id, -16} name={name, -16} instructor=men3m");

            //string path = "C:\Users\Men3m";
            //string path = "C:\\Users\\Men3m";
            //Console.WriteLine(@"C:\Users\Men3m");
            #endregion

            #region Casting, Conversions
            //short x;
            //Console.WriteLine(x);

            //short x = 23;
            //long l = 23;
            //short x = 33000; // xxx

            //float pi1 = (float)3.14;
            //float pi2 = 3.14f;
            //float pi3 = 3.14F;

            //decimal pi1 = (decimal)3.14;
            //decimal pi2 = 3.14m;
            //decimal pi3 = 3.14M;

            //double pi11 = 3.14d;
            //double pi12 = 3.14D;
            //double pi13 = (double)3.14;
            //double pi14 = 3.14;

            // int a = 97;
            // int a = 200000000;
            //char ch = a;

            //char c = 'A';
            //int a = c;
            //Console.WriteLine(a);

            //string input = Console.ReadLine();
            //int num1 = int.Parse(input);
            //double num2 = double.Parse(input);
            //float num3 = float.Parse(input);
            //Console.WriteLine(num1+2);


            //bool isValid = int.TryParse(input, out int num);


            //int num = 0;
            //bool isValid = int.TryParse(input, out num);

            //int num = 0;
            //string? input = Console.ReadLine();
            //if (int.TryParse(input, out num))
            //{
            //    num *= 10;
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}


            //Console.Write("Enter your salary: ");
            //string? salStr = Console.ReadLine();
            //double salary = Convert.ToDouble(salStr);
            //salary *= 1.1;
            //Console.WriteLine(salary);



            #endregion



            #region Control Statements
            // 1. Conditional Statements
            // if
            // if else
            // if else if .... else
            // ternary operator
            // switch

            //int num = int.Parse(Console.ReadLine()!);
            //if (num == 0)
            //{
            //    Console.WriteLine("Natural Number");
            //}
            //else if(num %2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //} else
            //{
            //    Console.WriteLine("Odd Number");
            //}


            //int num = int.Parse(Console.ReadLine()!);
            //(num % 2 == 0)?
            //   Console.WriteLine("Even Number")
            //   :
            //   Console.WriteLine("Odd Number");

            //Console.WriteLine((num % 2 != 0 ? "Odd" : (num == 0) ? "Natural" : "Even"));


            //int month = int.Parse(Console.ReadLine()!);
            //switch (month)
            //{
            //    case 1:
            //    case 13:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    case 4:
            //        Console.WriteLine("Apr");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("Jun");
            //        break;
            //    default:
            //        Console.WriteLine("come later");
            //        break;
            //}

            #endregion
            // 4 5
            //string[] inputs= Console.ReadLine().Split();
            //int a = int.Parse(inputs[0]);
            //int b = int.Parse(inputs[1]);

            #region Overflow

            checked
            {
                //int x = int.MaxValue + 1;
                ////Console.WriteLine(x);

                //x += 10;
                //long c = x;
                //Console.WriteLine(c);

            }

            short x = short.MaxValue;
            Console.WriteLine(short.MinValue);
            x+=2;
            Console.WriteLine(x);



            #endregion

        }
    }
}


//namespace FlightSystem
//{
//    class Book
//    {
//        public string Destination { get; set; }
//        public string TicketNumber { get; set; }
//    }
//}

//namespace LibrarySystem
//{
//    class Book
//    {
//        public string Author { get; set; }
//        public string Tile { get; set; }
//    }
//}