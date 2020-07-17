using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Person_Inheritance
{
    class Teacher : Person
    {
        /// <summary>
        /// three private properties for Teacher class
        /// </summary>
        #region properties
        private string _Class;
        private double _PayCheckForOneHour;
        private double _TimeNum;
        #endregion

        /// <summary>
        /// constructors
        /// </summary>
        #region Constructors
        public Teacher() { }

        public Teacher(string newclass,double paycheck,double timenum)
        {
            this.Class = newclass;
            this.TimeNum = timenum;
            this._PayCheckForOneHour = paycheck;
        }

        public Teacher(string newclass, double paycheck, double timenum, 
            string name, bool sex, string dateofbirth, string address) : base(name,sex,dateofbirth,address)
        {
            this.Class = newclass;
            this.TimeNum = timenum;
            this._PayCheckForOneHour = paycheck;
        }
        #endregion

        /// <summary>
        /// TeachersArray
        /// </summary>

        ArrayList teacherlist = new ArrayList();

        /// <summary>
        /// getter,setter
        /// </summary>
        #region getter_and_setter 
        public string Class
        {
            get => this._Class;
            set => this.Format_Class(value);
        }

        public double PayCheckForOneHour
        {
            get => this._PayCheckForOneHour;
            set => this._PayCheckForOneHour=value;
        }

        public double TimeNum
        {
            get => this._TimeNum;
            set => this.Format_TimeNum(value);
        }
        #endregion

        #region format properties
        private void Format_Class(string newclass)
        {
            if (newclass.StartsWith("g".ToUpper()) || newclass.StartsWith("h".ToUpper()) || newclass.StartsWith("i".ToUpper())
                || newclass.StartsWith("k".ToUpper()) || newclass.StartsWith("l".ToUpper()) || newclass.StartsWith("m".ToUpper()))
            {
                this._Class = newclass;
            }
            else
            {
                this._Class = "not allow";
            }
        }

        private void Format_TimeNum(double timeInOneMonth)
        {
            if (timeInOneMonth > 0 && timeInOneMonth < 480)
            {
                this._TimeNum = timeInOneMonth;
            }
            else 
            {
                this._TimeNum = -1;
            }     
        }
        #endregion

        #region override input and showinfo from base
        public override void InputInfo()
        {
            Console.WriteLine("enter your class");
            this.Class = Console.ReadLine();

            Console.WriteLine("enter your paycheck");
            this.PayCheckForOneHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter your time in this month");
            this.TimeNum = Convert.ToDouble(Console.ReadLine());

            base.InputInfo();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>information for teacher</returns>
        public override string ShowInfo()
        {
            return $"class={this.Class} paycheck={this.PayCheckForOneHour} times in one month={this.TimeNum} {base.ShowInfo()}";
        }
        #endregion

        public void Addteacher(Teacher teacher)
        {
            teacherlist.Add(teacher);
        }

        public int FindTeacher()
        {
            foreach (Teacher item in teacherlist)
            {
                if (item.Name == "son")
                {
                    return teacherlist.IndexOf(item);
                }
            }
            return -1;
        }
    }
}
