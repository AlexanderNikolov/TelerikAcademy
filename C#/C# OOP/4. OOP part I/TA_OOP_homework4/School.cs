using System;
using System.Collections.Generic;

namespace SchoolSpace
{
    public class School
    {
        private string name = string.Empty;
        private readonly List<Class> classes = new List<Class>();
        private readonly List<Teacher> teachers = new List<Teacher>();
        private readonly List<Student> students = new List<Student>();

        public School(string name)
        {
            this.Name = name;
        }

        #region Properties
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Field cannot be empty!");

                this.name = value;
            }
        } 
        #endregion

        #region Methods
        public School AddClass(params Class[] classes)
        {
            foreach (var item in classes)
                this.classes.Add(item);

            return this;
        }

        public School RemoveClass(Class _class)
        {
            this.classes.Remove(_class);

            return this;
        }

        public School AddTeacher(params Teacher[] teachers)
        {
            foreach (var item in teachers)
                this.teachers.Add(item);

            return this;
        }

        public School RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);

            return this;
        }

        public School AddStudent(params Student[] students)
        {
            foreach (var item in students)
                this.students.Add(item);

            return this;
        }

        public School RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }

        public override string ToString()
        {
            return string.Format(" {0}", this.Name);
        } 
        #endregion
    }
}
