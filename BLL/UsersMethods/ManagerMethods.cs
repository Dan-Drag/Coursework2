using DAL.Users;
using DAL.Group;
using DAL.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UsersMethods
{
    internal class ManagerMethods
    {
        public Student CreateStudent(int id, string name, string surname, string patronymic, string email, string password)
        {
            Student student = new Student(id, name, surname, patronymic, email, password);
            return student;
        }
        public Lecturer CreateLectuare(int id, string name, string surname, string patronymic, string email, string password)
        {
            Lecturer Lectuare = new Lecturer(id, name, surname, patronymic, email, password);
            return Lectuare;
        }

        public Group CreateGroup()
        {
            Random random = new Random();
            int rand = random.Next(1, 1000);
            int course = int.Parse(Console.ReadLine());
            string title = Console.ReadLine();
            int ID = course * 10000 + rand;
            Group group = new Group(ID, title, course);
            return group;
        }

        public void AddStudentToGroup(Student student, Group group)
        {
            group.students.Add(student);
        }
        
        public void DeleteStudentFromGroup(Student student, Group group)
        {
            group.students.Remove(student);
        }

        protected void ChangeName(User user, string name)
        {
            user.Name = name;
        }
        protected void ChangeSurname(User user, string surname)
        {
            user.Surname = surname;
        }
        protected void ChangePatronymic(User user, string patronymic)
        {
            user.Patronymic = patronymic;
        }

        protected void ChangeID(User user, int id)
        {
            user.ID = id;
        }

        protected void Mail(User user, string mail)
        {
            user.Email = mail;
        }

        protected void ChangeGroupName(Group group, string title) 
        {
            group.Title = title;
        }
        protected void AddSubjectToLecturer(Lecturer lecturer, Subject subject)
        {
            lecturer.subjects.Add(subject);
        }
    }
}
