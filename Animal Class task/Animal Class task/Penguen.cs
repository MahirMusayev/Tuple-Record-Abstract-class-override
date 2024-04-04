using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class_task
{
    internal class Penguen :Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Chicken");
        }
        public override void Fly()
        {
            Console.WriteLine("Sorry Pengui cannot fly");
        }
    }
}
