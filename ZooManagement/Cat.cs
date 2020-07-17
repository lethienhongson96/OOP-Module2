using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Cat : Animal
    {
        #region constructor

        public Cat() : base() { 
        
        }

        public Cat(string name) : base(name)
        {

        } 
        public Cat(string name,int age) : base(name,age)
        {

        }
        public Cat(string name,int age, string description) : base(name, age, description)
        {

        } 

        #endregion

        public override void Sound()
        {
            Console.WriteLine("meo meo");
        }
    }
}
