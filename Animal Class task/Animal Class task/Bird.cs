using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class_task
{
    abstract class Bird : Animal
    {
        //public abstract void Fly();
        public virtual void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
