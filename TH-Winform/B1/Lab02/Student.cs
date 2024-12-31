using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Student
    {
        //1. Field
        private string studentID;
        private string fullName;
        private float avgScore;
        private string faculty;

        //2. Property
        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AvgScore { get => avgScore; set => avgScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        //3. Constructor
        public Student()
        {
        }
        public Student(string studentID, string fullName, float avgScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.avgScore = avgScore;
            this.faculty = faculty;
        }

        //4. Methods
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap Ho ten Sinh vien: ");
            FullName = Console.ReadLine();
            Console.Write("Nhap Diem TB: ");
            AvgScore = float.Parse(Console.ReadLine());     //ep sang kieu float
            Console.Write("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }
        
        public void Show()
        {
            Console.WriteLine("MSSV: {0} Ho Ten:{1} Khoa:{2} DiemTB:{3}",this.StudentID,this.fullName,this.Faculty, this.AvgScore);
        }
    }
}
