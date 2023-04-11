using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryPattern.Models;

namespace RepositoryPattern.Models
{
    public class StudentRepository : Istudent
    {
        db db = new db();
        public void Addnewrecord(Student svm)
        {
            Student s = new Student();
            s.std_name = svm.std_name;
            s.std_dob = svm.std_dob;
            db.students.Add(s);
            db.SaveChanges();
        }

        public void DeleteRecord(Student svm)
        {
            Student s = db.students.Where(x => x.StudentId == svm.StudentId).FirstOrDefault();
            db.students.Remove(s);
            db.SaveChanges();
        }

        public void EditRecord(Student svm)
        {
            Student s = db.students.Where(x=> x.StudentId== svm.StudentId).FirstOrDefault();
            s.std_name= svm.std_name;
            s.std_dob= svm.std_dob;
            db.SaveChanges();
        }

        public IEnumerable<Student> getdata()
        {
            return db.students.ToList();
            //List<Student> li = new List<Student>();
            //var list = db.students.Select(r=> new Student { std_name = r.std_name, std_dob = r.std_dob, StudentId = r.StudentId }).ToList();
            //foreach (Student s in list)
            //{
            //    li.Add(s);
            //}
            //return li;
        }

        public Student search(int id)
        {
            Student s = new Student();
            Student se = db.students.Where(x => x.StudentId == id).SingleOrDefault();
            s.StudentId = se.StudentId;
            s.std_name = se.std_name;
            s.std_dob = se.std_dob;

            return s;
        }
    }
}