using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Subjects;

namespace DAL.Users
{
    public class Lecturer : User
    {
        public List<Subject> subjects = new List<Subject>(); 
        public Lecturer(int iD, string name, string surname, string patronymic, string email, string password)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Lecturer";
            subjects = new List<Subject>();
        }
    }
}
