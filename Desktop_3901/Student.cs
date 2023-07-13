using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Desktop_3901
{
    public partial class Student
    {

        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id { get; set; }
        public BitmapImage Image { get; set; }
        public double GPA { get; set; }
        public string? DateofBirth { get; set; }
      
        public Student(int id,string firstname, string lastname,string dateofbirth, double gpa, BitmapImage image)
        {
            FirstName = firstname;
            LastName = lastname;
            Id = id;
            DateofBirth = dateofbirth;
            GPA = gpa;
            Image = image;

        }

        public Student()
        {

        }

        
    }
}
