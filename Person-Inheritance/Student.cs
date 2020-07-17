using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Inheritance
{
    class Student : Person
    {
        private int _Id;
        private double _AvgScore;
        private string _Email;

        //constructor
        public Student() { }

        public Student(double avgscore, string email) 
        {
            this._AvgScore = avgscore;
            this._Email = email;
            SetId();
        }

        public Student(double avgscore,string email, string name, bool sex, string dateofbirth, string address)
            :base(name,sex,dateofbirth, address)
        {
            this.SetEmail(email);
            this.SetAvg(avgscore);

            SetId();
        }
        //getter and setter

        public double AvgScore 
        {
            get => this._AvgScore;
            set => this.SetAvg(value);
        }

        public void SetAvg(double avg)
        {
            if (avg > 0.0 && avg < 10.0)
            {
                this.AvgScore = avg;
            }
            else
            {
                this.AvgScore = -1;
            }
        }

        public string Email
        {
            get => this._Email;
            set => this.SetEmail(value);
        }

        public void SetEmail(string email)
        {
            var addr = new System.Net.Mail.MailAddress(email);
            if (addr.Address == email)
            {
                this.Email = email;
            }
            else
            {
                this.Email = "not allow";
            }
        }


        public int GetId() => this._Id;

        public void SetId()
        {
            Random rndId = new Random();
            this._Id = rndId.Next(10000000, 100000000);
        }
        
        //input for Object

        public override void InputInfo()
        {
            Console.WriteLine("enter your email");
            string email = Console.ReadLine();

            this.SetEmail(email);
                
            Console.WriteLine("enter your AvgScore");
            double Avg = Convert.ToDouble(Console.ReadLine());

            this.SetAvg(Avg);

            base.InputInfo();
        }
        //override showinfo from Person class

        public override string ShowInfo()
        {
            return($"id={this.GetId()} AvgScore={this.AvgScore} Email={this.Email} {base.ShowInfo()}") ;
        }

    }
}
