using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            // defult Constructor 
            clockType empty_time = new clockType();
            Console.WriteLine("Empty Time :");
            empty_time.printTime();

            // Parameterized Constuctor (one parameter)
            clockType hour_Time = new clockType(8);
            Console.WriteLine("Hours Time :");
            hour_Time.printTime();

            // Parameterized Constuctor (two parameter)
            clockType minutes_Time = new clockType(8,10);
            Console.WriteLine("Minutes Time :");
            minutes_Time.printTime();

            // Parameterized Constuctor (three parameter)
            clockType Full_Time = new clockType(8, 10,10);
            Console.WriteLine("Full Time :");
            Full_Time.printTime();

            // increment Hours 
            Full_Time.incrementHour();
            Console.WriteLine("Full Time (increment Hours )");
            Full_Time.printTime();


            // increment minutes 
            Full_Time.incrementMinutes();
            Console.WriteLine("Full Time (increment minutes )");
            Full_Time.printTime();


            // increment second 
            Full_Time.incrementSecond();
            Console.WriteLine("Full Time (increment second )");
            Full_Time.printTime();

            // check if equal
            bool flag = Full_Time.isEqual(9, 11, 11);
            Console.WriteLine("Flag ::" + flag);

            // check if equal Objects
            clockType cmp = new clockType(10, 12, 1);
            flag = Full_Time.isEqual(cmp);
            Console.WriteLine("Object  Flag ::" + flag);
            Console.ReadKey();

        }
        /* static void Selftask1()
         {
             student s1 = new student();
             Console.WriteLine(s1.name);
             Console.WriteLine(s1.matric_marks);
             Console.WriteLine(s1.fsc_marks);
             Console.WriteLine(s1.aggegrate);
             Console.WriteLine(s1.ecat_marks);

         }
         static void Selftask2()
         {
             student s2 = new student();
             Console.WriteLine(s2.name);
             Console.WriteLine(s2.matric_marks);
             Console.WriteLine(s2.fsc_marks);
             Console.WriteLine(s2.aggegrate);
             Console.WriteLine(s2.ecat_marks);
             Console.Read();
         }*/
        /*  static void task()
          {
              student s1 = new student("marsad",1020,1020,200,198);
              Console.WriteLine("name {0}", s1.name);
              Console.WriteLine("matric marks {0}", s1.matric_marks);
              Console.WriteLine("inter marks {0}", s1.fsc_marks);
              Console.WriteLine("ecat marks {0}", s1.ecat_marks);
              student s2 = new student("jutt",1060,1020,160,188);
              Console.WriteLine("name {0}", s2.name);
              Console.WriteLine("matric marks {0}", s2.matric_marks);
              Console.WriteLine("inter marks {0}", s2.fsc_marks);
              Console.WriteLine("ecat marks {0}", s2.ecat_marks);
              Console.ReadKey();
          }*/
        /* static void task()
         {
             student s1 = new student();
             Console.WriteLine("name {0}", s1.name);
             Console.WriteLine("matric marks {0}", s1.matric_marks);
             Console.WriteLine("fsc marks {0}", s1.fsc_marks);

             Console.ReadKey();
         }*/
        /*  static void forTask()
          {
              List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
              for (int i = 0; i < numbers.Count; i++)
              {
                  Console.WriteLine("numbers   {0}", numbers[i]);
              }
              Console.ReadLine();
          }
          static void foreachTask()
          {
              List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
              foreach (int i in numbers)
              {
                  Console.WriteLine("numbers   {0}", i);
              }
              Console.ReadLine();

          }*/



    }
}