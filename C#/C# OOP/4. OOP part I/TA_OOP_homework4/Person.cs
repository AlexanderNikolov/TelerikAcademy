using System;
using System.Collections.Generic;

namespace SchoolSpace
{
    public abstract class Person
    {
        private string firstName = string.Empty;
        private string midName = string.Empty;
        private string lastName = string.Empty;

        public Person(string first, string middle, string last)
        {
            this.FirstName = first;
            this.MidName = middle;
            this.LastName = last;
        }

        #region Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Field cannot be empty!");

                this.firstName = value;
            }
        }

        public string MidName
        {
            get
            {
                return this.midName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Field \"Middle name\" cannot be empty!");

                this.midName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Field \"Last name\" cannot be empty!");

                this.lastName = value;
            }
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format(" {0} {1}", this.FirstName, this.LastName);
        }

        public void AddStudent()
        {

        }

        public void AddTeacher()
        {

        } 
        #endregion
    }
}
