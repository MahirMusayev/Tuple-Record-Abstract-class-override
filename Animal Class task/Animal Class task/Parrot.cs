using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Animal_Class_task
{ 
    class Parrot : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Parrot");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Parrot");
        }


        public void Talk()
        {
            Console.WriteLine("cici  kush");
        }
    }

}
