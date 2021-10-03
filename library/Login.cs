using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Login
    {

        public string name;
        public string password;
        public string StudentID;
        public string EmployeeID;

        public void Loginseen()
        {
            ////สร้างไวล์ลูปโดยเลื่อก1เป็นข้อมูลนักเรียนเเละ2เป็นพนักงาน
            int login = 0;
            while (login == 0)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Student Management");
                    Console.WriteLine("----------------");
                    Console.Write("Student ID:  ");
                    Console.ReadLine();

                    break;
                }
                else if (num == 2)
                {
                    Console.WriteLine("Employyee Management");
                    Console.WriteLine("----------------");

                    Console.Write("Employee ID:  ");
                    Console.ReadLine();
                    break;
                }

            }

        }
    }
}
