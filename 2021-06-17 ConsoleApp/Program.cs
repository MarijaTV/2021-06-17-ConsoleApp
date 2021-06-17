using System;
using System.Collections.Generic;
using System.Linq;

namespace _2021_06_17_ConsoleApp
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            List<List<String>> mokiniai = new List<List<string>>();

            List<String> vardai = new List<String>();
            List<String> pavarde = new List<String>();
            List<String> amzius = new List<String>();

            vardai.Add("Petras");
            pavarde.Add("Cvirka");
            amzius.Add("penkiolika");
            vardai.Add("Marytė");
            pavarde.Add("Melnikaite");
            amzius.Add("septyniolika");


            mokiniai.Add(vardai);
            mokiniai.Add(pavarde);
            mokiniai.Add(amzius);

            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(RandomString(random.Next(3, 12)), RandomString(random.Next(7, 20)), random.Next(18, 60), numArr(3, 14, 1, 10)));
            }
            Console.WriteLine(students.Count);


            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }



            public static int[] numArr(int arrMin, int arrMax, int valMin, int valMax)
        {
            int[] numArr = new int [random.Next(arrMin, arrMax)];
            for (int a = 0; a < numArr.Length; a++)
            {
                numArr[a] = random.Next(valMin, valMax +1);
            }
                return numArr;
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }








        //for (int i = 0; i < mokiniai[0].Count; i++)
        //{
        //    for (int a = 0; a < mokiniai.Count; a++)
        //    {
        //        Console.WriteLine(mokiniai[a][i]);
        //        Console.WriteLine(------);
        //    }
        //}
        
            //List<int> skaiciai = new List<int> { 1, 5, 8, 7, 9, 2, 12, 45, 66, 25, 18 };
            //Console.WriteLine(skaiciai);

            //for (int i = 0; i < skaiciai.Count; i++) //pirmas sąrašo atvaizdavimas
            //{
            //    Console.Write(skaiciai[i] + " ");
            //}


            //Console.WriteLine(""); //paprastas rūšiavimas
            //for (int a = 0; a < skaiciai.Count; a++)
            //    for (int i = 0; i < skaiciai.Count - 1; i++)
            //    {
            //        if (skaiciai[i] > skaiciai[i + 1])
            //        {
            //            int tmp = skaiciai[i];
            //            skaiciai[i] = skaiciai[i + 1];
            //            skaiciai[i + 1] = tmp;
            //        }
            //    }

            //for (int i = 0; i < skaiciai.Count; i++) //antro sąrašo atvaizdavimas
            //{
            //    Console.Write(skaiciai[i] + " ");
            //}


            //Console.WriteLine("");
            //for (int a = 0; a < skaiciai.Count; a++)

            //    for (int i = a + 1; i < skaiciai.Count; i++)
            //    {
            //        if (skaiciai[a] > skaiciai[i])
            //        {
            //            int tmp = skaiciai[a];
            //            skaiciai[a] = skaiciai[i];
            //            skaiciai[i] = tmp;
            //        }
            //    }
            //string[] tmpArr = vardai.ToArray(); // surūšiavimas
            //Array.Sort(vardai.ToArray(), StringComparer.Ordinal);
            //for (int i = 0; i < vardai.Count; i++)
            //{
            //    Console.WriteLine(vardai[i] + " ");
            //}
            //Console.WriteLine("");

//for (int i = 0; i < skaiciai.Count; i++) //antro sąrašo atvaizdavimas
//{
//    Console.Write(skaiciai[i] + " ");
//}


    }
}
