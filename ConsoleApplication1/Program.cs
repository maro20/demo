using AdventureWorks.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new AdventureWorks2012Entities())
            {

                var persons = from p in db.People
                              select p;


                foreach (Person p in persons)
                {
                    Console.WriteLine(p.LastName);
                    
                }


                
            }

        }
    }
}
