using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Student:Person
    {
        //1. Field
        private float avgScore;
        private string faculty;

        //2. Property
        public float AvgScore { get => avgScore; set => avgScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        //3. Constructor
        public Student()
        {
        }
        public Student(string personID, string fullName, float avgScore, string faculty):base(personID,fullName)
        {
            this.avgScore = avgScore;
            this.faculty = faculty;
        }

        //4. Methods
        public void Input()
        {
            Console.Write("Nhap Diem TB: ");
            AvgScore = float.Parse(Console.ReadLine());     //ep sang kieu float
            Console.Write("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine(" Khoa:{0} DiemTB:{1}",this.Faculty, this.AvgScore);
        }
    }
}
