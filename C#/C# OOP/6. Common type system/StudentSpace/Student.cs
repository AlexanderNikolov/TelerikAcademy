namespace StudentSpace
{
    using System;
    using System.Linq;

    public class Student : ICloneable, IComparable<Student>
    {
        //short implementation of class (dont care about this fields for now)
        //go for overrides and other hard stuff
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public uint SSN { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }

        public Student(string name, uint ssn)
        {
            FirstName = name;
            SSN = ssn;
        }

        //implement of enums
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public object Clone()
        {
            return new Student(this.FirstName, this.SSN);
        }

        public int CompareTo(Student other)
        {
            if (this.Equals(other))
                return 0;

            var selected = new Student[] { this, other }.OrderBy(student => student.FirstName)
                                                        .ThenBy(student => student.SSN)
                                                        .First();

            return this.Equals(selected) ? -1 : 1;
        }

        //methods section
        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            if (other == null)
                return false;

            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, other.FirstName))
                return false;

            // Compare the value type member fields
            if (this.SSN != other.SSN)
                return false;

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format(
                "Student(Name: {0}, SSN: {1})",
                this.FirstName ?? "<unnamed>", this.SSN); //<- undefined case
        }
    }
}
