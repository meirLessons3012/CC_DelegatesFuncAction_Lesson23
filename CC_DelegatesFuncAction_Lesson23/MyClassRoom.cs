using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_DelegatesFuncAction_Lesson23
{
    public delegate bool CheckIfStudentExistDelegate(Student student, Student compareTo);
    internal class MyClassRoom
    {
        public List<Student> Students { get; set; }


        public bool CheckIfStudnetExist(CheckIfStudentExistDelegate myDel, Student compareTo)
        {
            foreach (Student stud in Students)
            {
                if (myDel.Invoke(stud, compareTo))
                    return true;
            }
            return false;
        }

        //public bool CheckIfStudentExistById(int id)
        //{
        //    foreach (Student stud in Students)
        //    {
        //        if (stud.Id == id)
        //            return true;
        //    }
        //    return false;
        //}

        //public bool CheckIfStudentExistByName(string name)
        //{
        //    foreach (Student stud in Students)
        //    {
        //        if (stud.Name == name)
        //            return true;
        //    }
        //    return false;
        //}

        //public bool CheckIfStudentExistByGrade(double grade)
        //{
        //    foreach (Student stud in Students)
        //    {
        //        if (stud.Grade == grade)
        //            return true;
        //    }
        //    return false;
        //}
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

    }

    public class StudentChecker
    {
        public bool CheckStduentById(Student std, Student compareTo)
        {
            return std.Id == compareTo.Id;
        }

        public bool CheckStduentByName(Student std, Student compareTo)
        {
            return std.Name == compareTo.Name;
        }

        public bool CheckStduentByGrade(Student std, Student compareTo)
        {
            return std.Grade == compareTo.Grade;
        }
    }
}
