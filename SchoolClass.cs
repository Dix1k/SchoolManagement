using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class SchoolClass
    {
        public string ClassName { get; set; } // Название класса
        public List<string> Subjects { get; set; } // Список предметов

        public SchoolClass(string className)
        {
            ClassName = className;
            Subjects = new List<string>();
        }

        // Метод для добавления предмета
        public void AddSubject(string subject)
        {
            Subjects.Add(subject);
        }
    }
}