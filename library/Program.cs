using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Select Menu:");


            int select = 0;
            int num = int.Parse(Console.ReadLine());
            while (select == 0)
            {
               
                    if (num == 1)
                    {

                    Console.WriteLine("Login");
                    Console.WriteLine("------------------------");
                    Login login = new Login();

                    login.name = "Name:  ";
                    login.password = "Input password:  ";
                   

                    Console.WriteLine("Login Screen");
                    Console.WriteLine("----------------");
                    Console.WriteLine(login.name);
                    Console.ReadLine();
                    Console.WriteLine(login.password);
                    Console.ReadLine();
                    Console.Write("Input User Type 1 = Student Mangement,2 = Employee Mangement: ");
                    login.Loginseen();
                    break;
                    }

                    else if (num == 2)
                    {
                        Console.WriteLine("Register");
                        Register register = new Register();

                        register.name = "Name: kittinun ";
                        register.password = "Input password: 1234 ";
                        register.StudentID = "Student ID:  62130701103 ";
                        register.EmployeeID = "Employee ID: 5214785 ";

                        Console.WriteLine("Register new Person");
                        Console.WriteLine("------------------------");
                        Console.Write(register.name);
                        Console.Write(register.password);
                        Console.Write("Input User Type 1 = Student,2 = Employee: ");
                        register.RegisternewPerson();
                        break;
                    }


                

            }
        }
    }
}
