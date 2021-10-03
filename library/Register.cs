using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Register
    {
        public string name;
        public string password;
        public string StudentID ;
        public string EmployeeID;

        public void RegisternewPerson()
        {
            int regist = 0;
            
            while (regist == 0) {
                int num = int.Parse(Console.ReadLine());
                if (num == 1) {
                    Console.WriteLine("Student");
                    Console.Write("Student ID: 62130701103 ");               
                    break;
                }
                else if (num == 2) {
                    Console.WriteLine("Employyee");
                    Console.Write("Employee ID: 5214785 ");            
                    break;
                }
            }
        }
        

    }
}
