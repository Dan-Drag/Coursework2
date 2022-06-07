using DAL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Group
{
    public class Group
    {
        public int ID;
        public string Title;
        public int Course;
        public List<Student> students = new List<Student>(); 
        public Group(int iD, string title, int course)
        {
            List<Student> students = new List<Student>();
            ID = iD;
            Title = title;
            Course = course;
            this.students = students;
        }
    }
}
