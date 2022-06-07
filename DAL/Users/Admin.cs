using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Users
{
    public class Admin : User
    {
        public Admin(int iD, string name, string surname, string patronymic, string email, string password)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Admin";
        }
    }
}
