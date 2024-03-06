using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Program
    {
        static void Main()
        {
            decimal num10, num11, res;
            Console.WriteLine("Enter First Number : ");
            num10 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            num11 = Convert.ToDecimal(Console.ReadLine());

            res = num10 + num11;
            //Console.WriteLine("The result is : {0}", res);
            Console.WriteLine("The result is: "+res);
            // int num = 20;
            // Console.WriteLine(num);

            // int num1;
            // Console.WriteLine("Enter the num value: ");
            // num1=Convert.ToInt16(Console.ReadLine()); //2 byte
            // Console.WriteLine(num1);

            // int num2;
            // Console.WriteLine("Enter the number: ");
            // num2=Convert.ToInt32(Console.ReadLine()); //4 byte
            // Console.WriteLine(num2);

            ////int num3;
            // Console.WriteLine("Enter the number: ");
            // // num3=Convert.ToInt64(Console.ReadLine());//4 byte //not 64 bit not Applicable
            // //Console.WriteLine(num3);

            // long num4;
            // Console.WriteLine("Enter Number");
            // num4 = Convert.ToInt64(Console.ReadLine()); //4 byte
            // Console.WriteLine(num4);

            // long num5;
            // Console.WriteLine("Enter Number");
            // num5 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(num5);

            // long num6;
            // Console.WriteLine("Enter Number");
            // num6 = Convert.ToInt16(Console.ReadLine());
            // Console.WriteLine(num6);

            // float num7;
            // num7 = Convert.ToInt16(Console.ReadLine()); //Can Take Int16, But this will work on Integer But not on decimals
            // num7 = Convert.ToInt32(Console.ReadLine()); //Can Take Int32, But this will work on Integer But not on decimals
            // num7 = Convert.ToInt64(Console.ReadLine()); //Can Take Int64, But this will work on Integer But not on decimals

            // num7 = Convert.ToSingle(Console.ReadLine()); //If you want to take value in decimal
            // Console.WriteLine(num7);


            // double num8;
            // num8= Convert.ToInt16(Console.ReadLine());
            // num8 = Convert.ToInt32(Console.ReadLine());
            // num8 = Convert.ToInt64(Console.ReadLine());
            // num8 = Convert.ToSingle(Console.ReadLine());
            // num8 = Convert.ToDouble(Console.ReadLine()); //8 byte

            // decimal num9;
            // num9 = Convert.ToInt64(Console.ReadLine());
            // num9 = Convert.ToDecimal(Console.ReadLine()); //16byte

            // char char1;
            // char1 = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine(char1);

            // string name;
            // //No need to convert String
            // Console.WriteLine("What is your Name? ");
            // name = Console.ReadLine();
            // Console.WriteLine(name);





        }
        //public void Operator()
        //{
        //    decimal num1, num2, res;
        //    Console.WriteLine("Enter First Number : ");
        //    num1 = Convert.ToDecimal(Console.Read());

        //    Console.WriteLine("Enter Second Number : ");
        //    num2 = Convert.ToDecimal(Console.Read());

        //    res = num1 + num2;
        //    Console.WriteLine("The result is : {0}", res);
        //}
    }
}
