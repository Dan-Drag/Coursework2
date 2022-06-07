using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Subjects
{
    public class Subject
    {
        string SubjectName;
        string SubjectDescription;
        public Subject(string subjectName, string subjectDescription)
        {
            SubjectName = subjectName;
            SubjectDescription = subjectDescription;
        }
    }
}
