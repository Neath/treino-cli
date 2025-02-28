using ConjuntoAlunos.Entities;
using System;
using System.Collections.Generic;

namespace ConjuntoAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> studentList = new HashSet<Student>();
            Console.Write("How many students for course A? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentList.Add(new Student(id));
            }

            Console.Write("How many students for course B? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentList.Add(new Student(id));
            }

            Console.Write("How many students for course C? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentList.Add(new Student(id));
            }

            Console.Write("Total students: ");
            Console.WriteLine(studentList.Count);

        }
    }
}
