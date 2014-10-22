/*
 * Define a class Student, which contains data about a student – first, middle and last name, 
 * SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
 * Use an enumeration for the specialties, universities and faculties. 
 * Override the standard methods, inherited by  System.Object: 
 * Equals(), ToString(), GetHashCode() and operators == and !=.
 */

namespace StudentSpace
{
    using System;

    public class Student
    {
        private string firstName;
        private string midName;
        private string lastName;
        private string SSN;
        private string address;
        private string cellPhone;
        private string eMail;

    }
}
