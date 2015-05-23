using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Training_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =new ContosoUniversityEntities())
            {
                foreach (var item in db.Course)
                {
                    Console.WriteLine(item.Title);
                }
                Console.WriteLine();
                foreach (var item in db.Department)
                {
                    Console.WriteLine(item.Name);
                    foreach (var c in item.Course)
                    {
                        Console.WriteLine("\t"+c.Title);
                    }
                }
            }
        }
    }
}
