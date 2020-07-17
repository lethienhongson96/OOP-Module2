using System;

namespace STUDENT_MANGEMENT
{
    
    class Program
    {
        public static Student students = new Student();
        static void Main(string[] args)
        { 
            do
            { 
                Console.WriteLine("press 1 to add new student");
                Console.WriteLine("press 2 to see student list");
                Console.WriteLine("press 3 to search student");
                Console.WriteLine("press 4 to edit student");
                Console.WriteLine("press 0 to close");

                int checkNum = Convert.ToInt32(Console.ReadLine());
                if (checkNum==0)
                {
                    break;
                }

                switch (checkNum)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        students.ViewListStudent();
                        break;
                    case 3:
                        FindStudent();
                        break;
                    case 4:
                        Edit();
                        break;
                }
            } while (true);
        }

        public static void add() 
        {
                Console.Write("enter your name: ");
                string name=Console.ReadLine();

                Console.Write("enter your birth day: ");
                string dateOfBirth = Console.ReadLine();

                Console.Write("enter your conutry: ");
                string native = Console.ReadLine();

                Console.Write("enter your class: ");
                string newClass = Console.ReadLine();

                Console.Write("enter your phone number:");
                int phone =Convert.ToInt32(Console.ReadLine());

            Student student = new Student(name, dateOfBirth, native, newClass, phone);

            students.InsertNewStudent(student);
            
        }
        public static void FindStudent()
        {
            Console.WriteLine("enter id: ");
            int idFind =Convert.ToInt32( Console.ReadLine());
            students.SearchStudent(idFind);
        }

        public static void Edit()
        {
            Console.WriteLine("enter student's id want to edit: ");
            int idFind = Convert.ToInt32(Console.ReadLine());

            int loca = students.FindID(idFind);
            if (loca!=-1)
            {
                Console.Write("edit name: ");
                string name = Console.ReadLine();

                Console.Write("edit birth day: ");
                string dateOfBirth = Console.ReadLine();

                Console.Write("edit conutry: ");
                string native = Console.ReadLine();

                Console.Write("edit class: ");
                string newClass = Console.ReadLine();

                Console.Write("edit phone number:");
                int phone = Convert.ToInt32(Console.ReadLine());

                students.EditStudent(loca, name,dateOfBirth,native,newClass,phone);
            }
            else
            {
                Console.WriteLine("not found!!!");
            }
        }

    }
}
