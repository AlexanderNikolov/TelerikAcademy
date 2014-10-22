namespace Persons
{
    using System;

    public class Person
    {
        public string Name { get; private set;}
        public string Age { get; set;}

        public Person(string name, string age) 
        {
            Name = name;
            Age = age;
        }

        //methods
        public override string ToString()
        {
            return ( this.Age == null ) 
                ? string.Format( "Name: {0} age: (uncpecified)", this.Name ) 
                : string.Format( "Name: {0} age: {1}", this.Name, this.Age);

            //can be done also with
            //return String.Format(
            //    "Person(Name: {0}, Age: {1})",
            //    this.Name , this.Age ?? "<uncpecified>");
        }
    }
}
