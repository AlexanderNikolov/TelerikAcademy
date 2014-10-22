using System;
using System.Text;

namespace SchoolSpace
{
    public class Teacher : Person, ICommentable
    {
        public Teacher(string firstName, string midName, string lastName)
            : base(firstName, midName, lastName)
        {
        }

        #region ICommentable
        public string Comment { get; set; } 
        #endregion

        #region Metods
        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.Append(" teacher ");
            temp.Append(base.ToString());
            return temp.ToString();
        } 
        #endregion
    }
}
