using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace Desktop_3901
{
    public partial class MainWindowVM : ObservableObject
    {

        [ObservableProperty]
        public ObservableCollection<Student> students;

        [ObservableProperty]
        public Student selectedStudent = null;
        public MainWindowVM()
        {

            students = new ObservableCollection<Student>();
            BitmapImage image1 = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            students.Add(new Student(100, "Dinuk", "Pathiraja", "11/05/1999", 3, image1));
            BitmapImage image2 = new BitmapImage(new Uri("/Images/4.png", UriKind.Relative));
            students.Add(new Student(101, "Selani", "Didulani", "11/05/1999", 3, image2));
            BitmapImage image3 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            students.Add(new Student(102, "Sumudu", "Chethana", "11/05/1999", 3, image3));
            BitmapImage image4 = new BitmapImage(new Uri("/Images/3.png", UriKind.Relative));
            students.Add(new Student(103, "Dinuk", "Pathiraja", "11/05/1999", 3, image4));
            BitmapImage image5 = new BitmapImage(new Uri("/Images/7.png", UriKind.Relative));
            students.Add(new Student(104, "Selani", "Didulani", "04/12/2000", 3, image5));
            BitmapImage image6 = new BitmapImage(new Uri("/Images/4.png", UriKind.Relative));
            students.Add(new Student(100, "Dinuk", "Pathiraja", "11/05/1999", 3, image6));
            BitmapImage image7 = new BitmapImage(new Uri("/Images/5.png", UriKind.Relative));
            students.Add(new Student(100, "Dinuk", "Pathiraja", "11/05/1999", 3, image7));
            BitmapImage image8 = new BitmapImage(new Uri("/Images/10.png", UriKind.Relative));
            students.Add(new Student(100, "Dinuk", "Pathiraja", "11/05/1999", 3, image8));
        }

        [RelayCommand]
        public void RemoveStudent()
        {
            if (SelectedStudent != null)
            {
                Students.Remove(SelectedStudent);
            }
            else
            {

                MessageBox.Show("No students in the list");
            }

        }

        [RelayCommand]

        public void EditStudent()
        {
            
            if(SelectedStudent != null)
            {
                Application.Current.MainWindow.Hide();
                var EditStuVM = new Add_StudentVM(SelectedStudent);
                Add_Student editwindow = new Add_Student(EditStuVM);
                EditStuVM.Title = "Edit Student Menu";
                editwindow.ShowDialog();
                
                int index = Students.IndexOf(SelectedStudent);
                Students.RemoveAt(index);
                Students.Insert(index,EditStuVM.Studentobj);
                
                
                
            }
            else
            {
                MessageBox.Show("Student not Selected");
            }

        }
        

        [RelayCommand]
        public void AddStudent()
        {

            var AddStuVM = new Add_StudentVM();
            Add_Student addwindow=new Add_Student(AddStuVM);
            Application.Current.MainWindow.Hide();
            AddStuVM.Title = "Add Student Menu";
            addwindow.ShowDialog();
            if(AddStuVM.Studentobj!=null)
            {
                Students.Add(AddStuVM.Studentobj);
                MessageBox.Show("Successfully Added");

            }
        }






    }
}




