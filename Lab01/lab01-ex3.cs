using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_ex03
{
    internal class Person
    {
        private string fullName;
        private int birthYear;
        private string degree;

        public string FullName { get => fullName; set => fullName = value; }

        public string Degree { get => degree; set => degree = value; }

        public int BirthYear { get => birthYear; set => birthYear = value; }

        public Person()
        {
            fullName = "No Name";
            BirthYear = 2000;
            degree = "Dai hoc";

        }

        public Person(string fullName, int birthYear, string degree)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Degree = degree;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Ho Ten: {FullName}");
            Console.WriteLine($"Nam Sinh: {BirthYear}");
            Console.WriteLine($"Bang Cap: {Degree}");
        }

        public override string ToString()
        {
            return $"{fullName} {BirthYear} {Degree}";
        }
    }

    // Lớp Student kế thừa Person
    internal class Student : Person
    {
        private int studentID;
        private string faculty;
        private float mark;

        public int StudentID { get => studentID; set => studentID = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public float Mark { get => mark; set => mark = value; }

        public Student() : base()
        {
            StudentID = 1;
            Faculty = "A";
            Mark = 0;
        }

        public Student(int id, string fullName, int birthYear, string degree,
                      string faculty, float mark)
           : base(fullName, birthYear, degree)
        {
            StudentID = id;
            Faculty = faculty;
            Mark = mark;
        }

        public override void Display()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"MSSV: {StudentID}");
            base.Display();
            Console.WriteLine($"Khoa: {Faculty}");
            Console.WriteLine($"Điểm TB: {Mark}");
            Console.WriteLine("=================================");
        }

        public override string ToString()
        {
            return $"MSSV: {StudentID} - {FullName} - {Faculty} - {Mark}";
        }

        public void InputData()
        {
            Console.Write(" Ma so sinh vien: ");
            StudentID = int.Parse(Console.ReadLine());

            Console.Write("  Ho Ten: ");
            FullName = Console.ReadLine();

            Console.Write(" Nam sinh: ");
            BirthYear = int.Parse(Console.ReadLine());

            Console.Write(" Bang cap: ");
            Degree = Console.ReadLine();

            Console.Write(" Khoa: ");
            Faculty = Console.ReadLine();

            Console.Write(" Diem trung binh: ");
            Mark = float.Parse(Console.ReadLine());
        }
    }
    internal class Tester
    {
        // Phuong thuc nhap mot sinh vien
        private static Student InputOneStudent(int index)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {0}", index);
            Student st = new Student();
            st.InputData();
            return st;
        }

        // Phương thức nhập danh sách sinh viên
        private static ArrayList InputStudentList(int n)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                students.Add(Tester.InputOneStudent(i));
            }
            return students;
        }

        // Phương thức xuất danh sách sinh viên
        private static void DisplayStudentList(ArrayList students)
        {
            Console.WriteLine("\n\n====== DANH SÁCH SINH VIÊN ======");
            int i = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"\n--- Sinh Vien Thu {i++} ---");
                student.Display();
            }

        }

        // Tìm sinh viên theo tên (trả về Student hoặc null)
        private static Student FindStudentByName(ArrayList students, string name)
        {
            foreach (Student st in students)
            {
                // So sánh không phân biệt hoa thường
                if (st.FullName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return st;
                }
            }
            return null;
        }

        // CalculateAverageMark of all students

        // Find Student by name (student / null)

        /*
		public static void Main(string[] args)
		{
			int n;
			Console.Write("Nhap vao so luong SV: ");
			n = int.Parse(Console.ReadLine());

			// Nhập danh sách sinh viên
			ArrayList DSSV = InputStudentList(n);

			// Xuất danh sách
			DisplayStudentList(DSSV);

			// ===== TÌM SINH VIÊN THEO TÊN =====
			Console.Write("\nNhap ten sinh vien can tim: ");
			string name = Console.ReadLine();

			Student result = FindStudentByName(DSSV, name);

			if (result != null)
			{
				Console.WriteLine("\n>>> TIM THAY SINH VIEN <<<");
				result.Display();
			}
			else
			{
				Console.WriteLine("\nKhong tim thay sinh vien co ten vua nhap!");
			}

			Console.ReadLine();
		}
		*/
    }
}
