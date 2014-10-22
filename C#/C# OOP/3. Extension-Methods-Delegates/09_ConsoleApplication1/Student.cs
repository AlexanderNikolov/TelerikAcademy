/*
 * 9. Create a class Student with properties FirstName, LastName, FN, Tel, 
 *    Email, Marks (a List<int>), GroupNumber. 
 */

namespace StudentSpace
{
    using System;
    using System.Collections.Generic;

    public class Student : IComparable<Student>
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phoneNumber;
        private string eMail;
        private string groupNumber;
        private List<int> marks;

        //.tor
        public Student(string first, string last, string number, string group,
            string phone, string mail, params int[] mrx)
        {
            this.FirstName = first;
            this.LastName = last;
            this.FacultyNumber = number;
            this.GroupNumber = group;
            this.PhoneNumber = phone;
            this.EMail = mail;
            this.marks = new List<int>(mrx);
        }

        //props
        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set { this.facultyNumber = value; } //readonly
        }

        public List<int> Marks
        {
            get { return new List<int>(this.marks); }
        }

        public string GroupNumber 
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
        
        public string PhoneNumber  
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        
        public string EMail  
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format(" {0, -8} {1,-8}, {2, -4}, G{3}, {4, -9}, {5, -23}, Marks [{6}]", this.firstName, this.lastName, this.facultyNumber, this.groupNumber, this.phoneNumber, this.eMail, string.Join(", ", this.Marks));
        }

        public int CompareTo(Student that)
        {
            if (Int32.Parse(this.groupNumber) > Int32.Parse(that.groupNumber)) return -1;
            if (Int32.Parse(this.groupNumber) == Int32.Parse(that.groupNumber)) return 0;
            return 1;
        }
    }
}
