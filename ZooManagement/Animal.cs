using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    abstract class Animal
    {
        private string _Name;
        private int _Age;
        private string _Description;
        private int _Id;

        #region constructor
        public Animal()
        {
            this._Id = this.ID;
        }

        public Animal(string name) 
        {
            this.Name = name;
            this._Id = this.ID;
        }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this._Id = this.ID;
        }

        public Animal(string name,int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
            this._Id = this.ID;
        }

        #endregion

        #region getter and setter

        public string Name
        {
            get => this._Name;
            set => this.SetName(value);
        }

        public void SetName(string name)
        {
            name = name.Trim();
            this._Name = name.ToUpper();
        }

        public int Age
        {
            get => this._Age;
            set => this.SetAge(value);
        }

        public void SetAge(int age)
        {
            if (age > 0 && age < 150)
            {
                this._Age = age;
            }

            else
            {
                this._Age = 9999;
            }    
        }

        public int ID
        {
            get => this._Id;
            set => this.SetId();
        }

        public void SetId()
        {
            Random rnd = new Random();
            this._Id = rnd.Next(100,1000);
        }

        public string Description
        {
            get => this._Description;
            set => this._Description = value;
        }
        #endregion

        public abstract void Sound();
        public virtual string Info()
        {
            return $"name={this.Name} age={this.Age} Description={this.Description}";
        }
    }
}
