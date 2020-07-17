using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Dog : Animal
    {
        public Dog() : base()
        {

        }

        public Dog(string name) : base(name)
        {

        }
        public Dog(string name, int age) : base(name, age)
        {

        }
        public Dog(string name, int age, string description) : base(name, age, description)
        {

        }


        public override void Sound()
        {
            Console.WriteLine("gau gau");
        }
    }
}
