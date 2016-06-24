﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    using Human;
    class SortHumans
    {
        public static void SortStudentsByGrade(List<Student> students)
        {
            var sortedStudents = students
                .OrderBy(x => x.getGrade())
                .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }

        public static void SortWorkersByMoney(List<Worker> workers)
        {
            var sortedWorkers = workers
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }

        public static void SortAllByFirstAndLastName(List<Student> students, List<Worker> workers)
        {
            var studentsAndWorkers = new List<Human.Human>();

            var sortAll = studentsAndWorkers
                .Concat(students)
                .Concat(workers)
                .ToList()
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            foreach (var person in sortAll)
            {
                Console.WriteLine(person);
            }
        }
    }
}
