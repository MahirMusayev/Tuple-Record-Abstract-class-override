using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class_task
{
    abstract class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
