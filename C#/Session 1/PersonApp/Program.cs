using PersonApp.CustomExcepton;
using PersonApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> peopleList = new List<Person>();
                peopleList.Add(new Person(20, 101, "Anurag", GenderType.Male, 5, 50));
                peopleList.Add(new Person(30, 102, "Anupam", GenderType.Male, 4, 40));
                peopleList.Add(new Person(40, 103, "Anupama", GenderType.Female, 6, 60));
                peopleList.Add(new Person(50, 105, "ASP", GenderType.Male, 6, 70));
                PrintDetailsForList(peopleList);
                //Person P1 = new Person(120, 101, "Anurag", GenderType.Male, 5, 50);
                //PrintDetails(P1);
                //P1.WorkOut();
                //PrintDetails(P1);
                //Person P2 = new Person(30, 102, "Anupam", GenderType.Male, 4, 40);
                //PrintDetails(P2);
                //Person P3 = new Person(40, 103, "Anupama", GenderType.Female, 6, 60);
                //PrintDetails(P3);
                //Person P4 = new Person(50, 105, "ASP", GenderType.Male, 6, 70);
                //PrintDetails(P4);
            }

            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
             
            }

        }

        public static void PrintDetails(Person person)
        {
            
            string Output = $"Age is {person.Age}\n" +
                            $"Id is {person.Id}\n" +
                            $"Name is {person.Name}\n" +
                            $"Gender is {person.Gender} \n" +
                            $"Height is {person.Height} \n" +
                            $"Weight is {person.Weight} \n" +
                            $"BMI Score is {person.BMI}";

            System.Console.WriteLine(Output);
            Console.WriteLine();
                            

        }

        public static void PrintDetailsForList(List<Person> person)
        {
            for(int i = 0; i < person.Count; i++)
            {
                System.Console.WriteLine(person[i].ToString());
                Console.WriteLine();
            }

        }


    }
}