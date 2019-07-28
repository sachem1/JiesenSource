using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Jiesen.Contract.Entitys;

namespace Jiesen.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestDbContext dbContext=new TestDbContext();
            Update_Test(dbContext);

        }


        private static void Insert_Test(TestDbContext dbContext)
        {
            dbContext.Insert(new Student() { Name = "zhangsan" });
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student() { Name = "lisi" + i });
            }
            dbContext.Insert(students);
        }

        private static void Update_Test(TestDbContext dbContext)
        {
            var student = dbContext.Fetch<Student>("select * from student");

            var student1=dbContext.QueryByProperty<Student>(student.FirstOrDefault(), x => new{x.Name});
            Console.ReadLine();
        }
    }
}
