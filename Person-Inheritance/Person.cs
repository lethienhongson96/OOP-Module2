using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Inheritance
{
    class Person
    {
        private string _Name;
        private bool _Sex;
        private string _DateOfBirth;
        private string _Address;

        public Person() { }

        public Person(string name, bool sex, string dateofbirth, string address)
        {
            this._Name = name;
            this._Sex = sex;
            this._DateOfBirth = dateofbirth;
            this._Address = address;
        }

        public string Name
        {
            get => this._Name;
            set => this._Name = value;
        }

        public bool Sex
        {
            get => this._Sex;
            set => this.Sex = value;
        }

        public string DateOfBirth
        {
            get => this._DateOfBirth;
            set => this._DateOfBirth = value;
        }

        public string Address
        {
            get => this._Address;
            set => this._Address = value;
        }

        public virtual void InputInfo()
        {
            Console.WriteLine("enter your name");
            this.Name = Console.ReadLine();

            Console.WriteLine("enter your name");
            this.Sex = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("enter your name");
            this.DateOfBirth = Console.ReadLine();

            Console.WriteLine("enter your name");
            this.Address = Console.ReadLine();
        }

        public virtual string ShowInfo()
        {
            return ($"name: {this.Name} sex: {this.Sex} date: {this.DateOfBirth} address: {this.Address}");
        }
    }
}
