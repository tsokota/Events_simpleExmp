using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Track_AL
{
    class Program
    {
        public static Scope Tasks = new Scope() {
            { new Task{ Name ="Task1", Estimated = 300} },
            { new Task{ Name ="Task2", Estimated = 400} },
            { new Task{ Name ="Task3", Estimated = 200} },
            { new Task{ Name ="Task4", Estimated = 100} },
            { new Task{ Name ="Task5", Estimated = 500} },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Total  " + Tasks.Total);

            Tasks[0].Done = 100;

            Console.WriteLine("Total  " + Tasks.Total);

            Tasks[1].Estimated = 600;

            Console.WriteLine("Total  " + Tasks.Total);
        }
    }
}
