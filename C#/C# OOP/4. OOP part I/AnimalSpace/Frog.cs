namespace AnimalSpace
{
    using System;

    class Frog : Animal, ISound
    {
        public Frog(string name, byte age) 
            : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string Sex 
        {
            get { return "male"; }
        }

        public override string Meal
        {
            get { return "flyes"; }
        }

        //implement .face
        public void MakeSound()
        {
            Console.WriteLine("Kwack-Kwack, wanna be a prince!\n"); ;
        }
    }
}
