namespace Animal_Class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot pasha = new Parrot();
            Shark akula = new Shark();
            Eagle eagle = new Eagle();
            Animal[] animals = { pasha, akula, eagle };
            Bird[] birds = { pasha, eagle ,new Penguen()};
            foreach (Bird bird in birds)
            {
                bird.Fly();
            }
            //pasha.Eat();
            //akula.Eat();
            //eagle.Fly();
            //pasha.Fly();
        }

    }
}
