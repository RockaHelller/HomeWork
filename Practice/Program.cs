using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework// Class-practice from record
            #region
            //int a = 5;
            //int b = a;
            //b = 18;
            //Console.WriteLine(a +"----"+ b);

            //int[] numbers1 = { 1, 3, 4, 5, 6, 7, 8 };
            //int[] numbers2 = numbers1;
            //numbers2[0] = 99;
            //Console.WriteLine(numbers1[0] +" "+ numbers2[0]);

            //int num = 13;
            //Console.WriteLine(num);
            //num += 3;
            //ShowNum(num);
            //Console.WriteLine(num);

            //int num;
            //ShowNum(out num);
            //num += 2;
            //Console.WriteLine(num);

            //int num = 10;
            //ShowNum(ref num);
            //num += 2;
            //Console.WriteLine(num);

            //string name1 = "Qoshqar";
            //string name2 = name1;
            //name2 = "Cavid";
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            //string name1;
            //CheckStr(out name1);
            //Console.WriteLine(name1);


            //string str1 = "Cav";
            //string str2 = "id";
            //string name = str1 + str2;
            //Console.WriteLine(name);


            //StringBuilder str = new StringBuilder();

            //str.Append("Cav");
            //str.Append("id");
            //Console.WriteLine(str);

            //String name1 = new string("Lale");
            //Console.WriteLine(name1);

            //int num = 55;

            //Boolean isMarried = new Boolean();


            // Console.WriteLine(name.Length);
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //name = String.Empty;

            //Console.WriteLine(name.StartsWith("R"));
            //Console.WriteLine(name.EndsWith("r"));

            //string name = "He-ll-o";

            //if (name.ToLower().StartsWith("R"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Console.WriteLine(name.Replace("Ramil","Resul"));

            //Console.WriteLine(name.Remove(3,4));

            //Console.WriteLine(name.Substring(3));

            //var result = name.Split("-");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "robot";
            //string[] arr = word.Split();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] words = { "one", "two", "three" };

            //Console.WriteLine(string.Join(" ", words));

            //string text = "Hello";

            //if (string.IsNullOrWhiteSpace(text))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}










            #endregion



            //5 Methods
            #region
            ////////////1.ConCat////////////
            //join two strings
            //string JoinTwoStrings = string.Concat(str1 + str2);
            //Console.WriteLine(JoinTwoStrings);



            ////////////2.Double quote////////////
            // include double quote
            //string str = "This is the "String" class";
            // use the escape character
            //string str = "This is the \"String\" class.";
            //Console.WriteLine(str);



            ///////////////////////3.Compare///////////////////////
            //string str1 = "Murad";
            //string str2 = "Code Academy";
            //string str3 = "Murad";

            ////compare str1 and str2
            //Boolean result1 = str1.Equals(str2);
            //Console.WriteLine("string str1 and str2 are equal: " + result1);

            ////compare str1 and str2
            //Boolean result2 = str1.Equals(str3);
            //Console.WriteLine("string str1 and str3 are equal: " + result2);



            ///////////////////////////4.Copy////////////////////////////
            //string a = "Murad";
            //string b = string.Copy(a);
            //Console.WriteLine(b);

            /////////////////////////5.Clone/////////////////////////////

            //String a = "hello";
            //String b = (String)a.Clone();
            //Console.WriteLine(b);



            #endregion

        }



        //public static void CheckStr(out string str)
        //{
        //    str = "Mahir";
        //    Console.WriteLine(str);
        //}

        //public static void ShowNum(ref int num)
        //    {
        //        num = 100;
        //        num += 2;
        //        Console.WriteLine(num);
        //    }

        //public static void ShowNum(out int num)
        //    {
        //        num = 100;
        //        num += 2;
        //        Console.WriteLine(num);
        //    }












    }
}
