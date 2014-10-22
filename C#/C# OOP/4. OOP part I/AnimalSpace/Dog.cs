namespace AnimalSpace
{
    using System;

    class Dog : Animal, ISound
    {
        public Dog(string name, byte age) 
            : base(name, age)
        {
        }
        
        public override string Meal
        {
            get { return "Sqooby snacks"; }
        }

        public override string Sex 
        {
            get { return "male"; }
        }

        //implement .face
        public void MakeSound()
        {
            Console.WriteLine("Scooby Douby Doooo!\n"); ;
        }
    }
}
