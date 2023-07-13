using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Desktop_3901
{
    public partial class Add_StudentVM:ObservableObject
    {
        [ObservableProperty]
        public int sid;

        [ObservableProperty]
        public string sfname;

        [ObservableProperty]
        public string slname;

        [ObservableProperty]
        public string sdob;
      
        [ObservableProperty]
        public double sgpa;

        [ObservableProperty]
        public string title;
        
        [ObservableProperty]
        public BitmapImage selectedImage;
        
        
        public Student Studentobj;

        public Action CloseAction { get; internal set; }

        public Action RefreshAction { get; internal set; }
       

        public Add_StudentVM(Student Studentpara)
        {
            Studentobj= Studentpara;
            sid = Studentobj.Id;
            sfname = Studentobj.FirstName;
            slname = Studentobj.LastName;
            sdob = Studentobj.DateofBirth;
            sgpa = Studentobj.GPA;
            selectedImage = Studentobj.Image;
        }

        public Add_StudentVM()
        {

        }

        [RelayCommand]
        public void Save()
        {
           
            if (Studentobj == null)
            { 
                Studentobj = new Student(sid, sfname, slname, sdob, sgpa, selectedImage);
            }
            else
            {

                Studentobj.Id = sid;
                Studentobj.FirstName = sfname;
                Studentobj.LastName = slname;
                Studentobj.DateofBirth = sdob;
                Studentobj.GPA = sgpa;
                Studentobj.Image=selectedImage;
                

            }

            if (sgpa < 0 || sgpa > 4)
            {
                MessageBox.Show("GPA must between 0 and 4");
            }
            else
            {
                if (Studentobj != null && Studentobj.Image != null)
                {

                    CloseAction();
                    Application.Current.MainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Fields are Empty.");
                }
            } 
        }



        [RelayCommand]
        public void UploadPhoto()
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files | *.png; *.bmp;  *.jpg; *.Gif;*.Jpegs;*.Bitmaps";
            
            if (file.ShowDialog() == true)
            {
                SelectedImage = new BitmapImage(new Uri(file.FileName));
                

                MessageBox.Show("Image successfuly uploded!", "Successfull");
            }
        }
       
        
    }
}

