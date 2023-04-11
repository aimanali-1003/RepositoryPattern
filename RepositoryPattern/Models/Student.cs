using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern.Models
{
    [Table ("tbl_student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Display(Name ="Name")]
        [Required]
        [StringLength (50)]
        [MaxLength(50)]

        
        public string std_name { get; set; }

        [Display(Name = "Date of birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime std_dob { get; set; }
    }

    //interface in repo -> totally abstraction (implemenetation details are hidden) interface has 100% abstraction and abstract class can have atleast one abstract class
    interface Istudent
    {
        //display
        IEnumerable<Student> getdata();
        //insert
        void Addnewrecord(Student svm);//student data goes from view model

        //update
        void EditRecord(Student svm);

        //delete
        void DeleteRecord(Student svm);
        //search
        Student search(int id);
    }

}