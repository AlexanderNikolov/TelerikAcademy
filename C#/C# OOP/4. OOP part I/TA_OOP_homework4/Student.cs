using System;
using System.Text;

namespace SchoolSpace
{
    public class Student : Person, ICommentable
    {
        private string number = string.Empty;

        public Student(string firstName, string midName, string lastName, string number)
            : base(firstName, midName, lastName)
        {
            this.StudentID = number;
        }

        #region Properties
        public string StudentID
        {
            get
            {
                return this.number;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Field \"StudentID\" cannot be empty!");
                this.number = value;
            }
        } 
        #endregion

        #region ICommentable
        //interface implementation
        public string Comment { get; set; } 
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(" student ");
            output.Append(base.ToString());
            output.Append(string.Format(" No.{0}", this.StudentID));
            return output.ToString();
        } 
        #endregion
    }
}
