using System;
using System.Collections;

namespace Person_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList teacherlist = new ArrayList();

            Teacher son = new Teacher("K",10.9,400,"hongson",true,"27/11/96","quangtri");

            teacherlist.Add(son);

            Teacher tan= new Teacher("H", 8.9, 300, "tan", false, "27/11/2020", "hue");

            teacherlist.Add(tan);

            Teacher vui = new Teacher("l", 20.1, 200, "vui", true, "27/11/210", "danang");

            teacherlist.Add(vui);
            int x = 1;
            teacherlist.Add(x);

            /* Console.WriteLine(teacherlist.IndexOf("hongson"));*/
            
        }
        
 
    }
}
