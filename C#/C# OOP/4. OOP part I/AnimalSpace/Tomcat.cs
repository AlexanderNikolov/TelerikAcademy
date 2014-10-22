namespace AnimalSpace
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, byte age, string breed) 
            : base(name, age, breed)
        {
        }

        //override abstract props from base class
        public override string Sex 
        {
            get { return "male"; }
        }

        public override string Meal 
        {
            get { return "mouse"; }
        }

        //implement .face
        public void MakeSound()
        {
            Console.WriteLine("Myauuuuu\n");
        }
    }
}
