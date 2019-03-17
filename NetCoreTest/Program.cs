using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var datas = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                datas.Add(new Student()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Replace("-","")
                });
            }

            Predicate<Student> re = u => u.Id>50;

            Console.WriteLine(             datas.Where(p => p.Id > 50).Count()                );
        }
    }


    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}