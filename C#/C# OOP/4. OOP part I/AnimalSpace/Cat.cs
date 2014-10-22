namespace AnimalSpace
{
    using System;

    public abstract class Cat : Animal
    {
        private string breed;

        //.tor
        public Cat(string name, byte age, string breed)
            : base(name, age)
        {
            this.Breed = breed;
        }

        public string Breed 
        {
            get { return this.breed; }
            set 
            {
                this.breed = value; 
            } 
        }

        //sex and meal still abstract prop
    }
}