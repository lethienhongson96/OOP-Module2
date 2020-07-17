using System;
using System.Collections.Generic;
using System.Text;

namespace STUDENT_MANGEMENT
{
    class Student : IStudent
    {
        Student[] students = new Student[0]; 

        public string FullName;
        private int _ID;
        public string DateOfBirth;
        public string Native;
        public string Class;
        public int PhoneNo;

        public Student() { }


        public Student(string fullname,string dateofbirth,string native, string newclass,int phone)
        {
            this.FullName = fullname;
            this.DateOfBirth = dateofbirth;
            this.Native = native;
            this.Class = newclass;
            this.PhoneNo = phone;
            this.SetId();
        }

        public int GetId=> this._ID;

        private void SetId() 
        {
            Random rnd = new Random();
            this._ID = rnd.Next(1000, 10000);
        } 
        
        //servece student

        public void InsertNewStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public void ViewListStudent()
        {
            for (int i=0;i<students.Length;i++)
            {
                students[i].Display();
                Console.WriteLine();
            }
        }

        public int FindID(int id)
        {
            for (int i=0;i<students.Length;i++)
            {
                if (students[i].GetId==id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void SearchStudent(int id)
        {
            int loca = this.FindID(id);

            if (loca == -1)
            {
                Console.WriteLine("not found");
            }

            else 
            {
                students[loca].Display();
            }
        }

        public void EditStudent(int loca, string fullname, string dateofbirth, string native, string newclass, int phone)
        {
            students[loca].FullName = fullname;
            students[loca].DateOfBirth = dateofbirth;
            students[loca].Native = native;
            students[loca].Class = newclass;
            students[loca].PhoneNo = phone;
        }

        public void Display()
        {
            Console.WriteLine($"{this.FullName} {this.GetId} {this.DateOfBirth} {this.Native} {this.Class} {this.PhoneNo}");
        }
    }
}
