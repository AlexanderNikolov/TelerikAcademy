using System;

namespace SchoolSpace
{
    public class Discipline : School, ICommentable
    {
        private string lecturesNumber = string.Empty;
        private string exercisesNumber = string.Empty;

        public Discipline (string name, string lectures, string exercises)
            : base(name)
        {
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        #region Properties
        public string Lectures
        {
            get
            {
                return this.lecturesNumber;
            }
            private set
            {
                this.lecturesNumber = value;
            }
        }

        public string Exercises
        {
            get
            {
                return this.exercisesNumber;
            }
            private set
            {
                this.exercisesNumber = value;
            }
        } 
        #endregion

        #region ICommentable
        //.face implementation
        public string Comment { get; set; } 
        #endregion
    }
}
