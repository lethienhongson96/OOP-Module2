using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Tiger : Animal
    {
        public Tiger() : base()
        {

        }

        public Tiger(string name) : base(name)
        {

        }
        public Tiger(string name, int age) : base(name, age)
        {

        }
        public Tiger(string name, int age, string description) : base(name, age, description)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("wooo");
        }
    }
}
