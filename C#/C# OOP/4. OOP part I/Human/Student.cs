using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanSpace
{
    public class Student : Human
    {
        public string Grade { get; private set;}
        
        public Student(string firstName, string lastName, string grade) : base (firstName, lastName)
        {
            this.Grade = grade;
        }

        //from Human
        public override string ToString()
        {
            return string.Format("{0, -7} {1, -5} {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
