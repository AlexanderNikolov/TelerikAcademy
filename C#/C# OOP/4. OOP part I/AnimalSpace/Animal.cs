using System;

namespace AnimalSpace
{
    public abstract class Animal
    {
        private string name;
        private byte age;

        //.tor
        public Animal(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public byte Age 
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }
        
        //abstract prop
        public abstract string Sex { get; }
        public abstract string Meal { get; }
    }
}