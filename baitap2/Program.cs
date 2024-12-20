using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bt2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student ( "1",  "Tran Trung Kien", 17),
                new Student ( "2",  "Vo Thi Que Chi", 27),
                new Student ( "3",  "Nguyen Thi Thu Thuy", 48),
                new Student ( "4",  "Nguyen Quoc Bao", 20),
                new Student ( "5",  "Dong Thu Thuy", 30),
                new Student ( "6",  " Dang The An", 18),
                new Student ( "7",  "Anh Ha Vu Nguyen", 15),

            };

            Console.WriteLine("---- Danh sach hoc sinh duoc khoi tao!\n ");
            //a. In danh sach toan bo sinh vien.

            Console.WriteLine("1. Toan bo danh sach sinh vien\n");
            students.ForEach(Student => Console.WriteLine(Student));
            Console.WriteLine();

            //b. Tim va in ra danh sach cac sinh vien tu 15 den 18 tuoi.

            Console.WriteLine("2. Sinh vien co do tuoi tu 15 den 18 tuoi!\n");
            var ageRangeStudent = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            if (ageRangeStudent.Any())
            {
                ageRangeStudent.ForEach(Student => Console.WriteLine(Student));
            }
            else
            {
                Console.WriteLine("     Khong co hoc sinh trong do tuoi nay.");

            }
            Console.WriteLine();

            //c. Tim va in ra sinh vien co ten bat dau bang chu 'A'.

            Console.WriteLine("3. Sinh vien co ten bat dau bang chu 'A': ");
            var StudentWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            if (StudentWithA.Any())
            {
                StudentWithA.ForEach(Student => Console.WriteLine(Student));
            }
            else
            {
                Console.WriteLine("     Khong co sinh vien co ten bat dau bang chu 'A'.");
            }
            Console.WriteLine();

            // d. Tinh tong tuoi tat ca sinh vien trong danh sach.

            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"4. Tong tuoi tat ca sinh vien: {totalAge}\n");

            // e.Tim va in ra sinh vien co tuoi lon nhat.

            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge).ToList();
            Console.WriteLine("5. Sinh vien co tuoi lon nhat:");
            oldestStudents.ForEach(student => Console.WriteLine(student));
            Console.WriteLine();

            // f. Sap xep danh sach sinh vien theo tuoi tang dan va in ra danh sach sau khi sap xep.

            Console.WriteLine("6.Danh sach sau khi sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            sortedStudents.ForEach(student => Console.WriteLine(student));

            Console.WriteLine("\n---- Ket thuc chuong trinh quan ly danh sach sinh vien.");
            Console.ReadKey();



        }

    }
}
