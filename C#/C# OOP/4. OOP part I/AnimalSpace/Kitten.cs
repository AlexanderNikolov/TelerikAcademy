namespace AnimalSpace
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, byte age, string breed)
            : base(name, age, breed)
        {
        }

        //override abstract props from base class
        public override string Sex 
        {
            get { return "female"; }
        }
        
        public override string Meal 
        {
            get { return "milk"; }
        }

        //implement .face
        public void MakeSound()
        {
            Console.WriteLine("Mrr-Mrr\n"); ;
        }
    }
}
