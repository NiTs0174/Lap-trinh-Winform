using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhap thong tin sinh vien ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh vien thanh cong!");
        }

        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach chi tiet thong tin sinh vien ===");
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }
        //case 3- DSSV CNTT
        static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien thuoc khoa {0}", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        //case 4: xuat thong tin sv co dtb >= 5
        static void DisplayStudentsWithHighAvgScoce(List<Student> studentList, float minDTB)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem TB >= {0}", minDTB);
            var students = studentList.Where(s => s.AvgScore >= minDTB).ToList();
            DisplayStudentList(students);
        }
        //case 5: xuat dssv sap xep theo dtb tang dan
        static void SortStudentsByAvgScore(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach sinh vien duoc sap xep theo diem trung binh tang dan ===");
            var sortedStudents = studentList.OrderBy(s => s.AvgScore).ToList();
            DisplayStudentList(sortedStudents);
        }
        //case 6: DSSV co DTB >=5 va thuoc khoa CNTT
        static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem TB >= {0} va thuoc khoa {1}",minDTB, faculty);
            var students = studentList.Where(s => s.AvgScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        //case 7: DSSV co DTB max va thuoc khoa CNTT
        static void DisplayStudentWithHighestAverageByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Sinh viên có điểm TB cao nhất khoa {0} ===", faculty);
            var studentsInFaculty = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();

            if (studentsInFaculty.Count > 0)
            {
                var highestAvgScore = studentsInFaculty.Max(s => s.AvgScore);
                var topStudents = studentsInFaculty.Where(s => s.AvgScore == highestAvgScore).ToList();

                Console.WriteLine("Điểm TB cao nhất trong khoa {0}: {1}", faculty, highestAvgScore);

                Console.WriteLine("Danh sách sinh viên có điểm TB cao nhất:");
                DisplayStudentList(topStudents);
            }
            else
                Console.WriteLine("Không có sinh viên thuộc khoa {0} trong danh sách.", faculty);
        }
        //case 8
        static void CountStudentsByGrade(List<Student> studentList)
        {
            Console.WriteLine("=== Số lượng của từng xếp loại ===");

            // Tạo biến để theo dõi số lượng từng loại
            int xuatSacCount = 0;
            int gioiCount = 0;
            int khaCount = 0;
            int trungBinhCount = 0;
            int yeuCount = 0;
            int kemCount = 0;

            foreach (Student student in studentList)
            {
                float avgScore = student.AvgScore;

                // Dựa trên thang điểm 10, xác định xếp loại cho từng sinh viên
                if (avgScore >= 9.0)
                    xuatSacCount++;
                else if (avgScore >= 8.0)
                    gioiCount++;
                else if (avgScore >= 7.0)
                    khaCount++;
                else if (avgScore >= 5.0)
                    trungBinhCount++;
                else if (avgScore >= 4.0)
                    yeuCount++;
                else
                    kemCount++;
            }

            // In ra số lượng của từng xếp loại
            Console.WriteLine("Xuất sắc: {0} sinh viên", xuatSacCount);
            Console.WriteLine("Giỏi: {0} sinh viên", gioiCount);
            Console.WriteLine("Khá: {0} sinh viên", khaCount);
            Console.WriteLine("Trung bình: {0} sinh viên", trungBinhCount);
            Console.WriteLine("Yếu: {0} sinh viên", yeuCount);
            Console.WriteLine("Kém: {0} sinh viên", kemCount);
        }


        //MAIN
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Them Sinh vien");
                Console.WriteLine("2. Hien thi Danh sach Sinh vien");
                Console.WriteLine("3. Hien thi Danh sach Sinh vien khoa CNTT");
                Console.WriteLine("4. Hien thi Danh sach Sinh vien DTB >= 5");
                Console.WriteLine("5. Hien thi Danh sach Sinh vien co DTB tang dan");
                Console.WriteLine("6. Hien thi Danh sach Sinh vien DTB >=5 & thuoc khoa CNTT");
                Console.WriteLine("7. Hien thi Danh sach Sinh vien DTB cao nhat & thuoc khoa CNTT");
                Console.WriteLine("8. Hien thi so luong xep loai theo danh sach");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Chon Chuc nang (0-8): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        DisplayStudentList(studentList);
                        break;
                    case "3":
                        DisplayStudentsByFaculty(studentList, "CNTT");
                        break;
                    case "4":
                        DisplayStudentsWithHighAvgScoce(studentList, 5);
                        break;
                    case "5":
                        SortStudentsByAvgScore(studentList);
                        break;
                    case "6":
                        DisplayStudentsByFacultyAndScore(studentList, "CNTT",5);
                        break;
                    case "7":
                        DisplayStudentWithHighestAverageByFaculty(studentList, "CNTT");
                        break;
                    case "8":
                        CountStudentsByGrade(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long chon lai.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
