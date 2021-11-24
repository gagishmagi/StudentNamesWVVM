using StudentNamesWVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamesWVVM.ViewModels
{
    internal class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Yuri", LastName = "Vosk" });
            students.Add(new Student { FirstName = "Guy", LastName = "Tagger" });
            students.Add(new Student { FirstName = "Ziv", LastName = "Brauner" });
            students.Add(new Student { FirstName = "Taly", LastName = "Golan" });

            Students = students;
        }
    }
}
