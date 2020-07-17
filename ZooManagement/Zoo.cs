using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Zoo
    {
        ArrayList coteList = new ArrayList();
        public void AddCote(Cote cote)
        {
            coteList.Add(cote);
        }

        public int FindIndex(int idCote)
        {
            int i = -1;
            foreach (Cote item in coteList)
            {
                i++;
                if (item.ID == idCote)
                {
                    return i;
                }
            }

            return -1;
        }

        public void DeleteCote(int idCote)
        {
            if (FindIndex(idCote) != -1)
            {
                coteList.RemoveAt(FindIndex(idCote));
            }

            else 
            {
                Console.WriteLine("not found");
            }
        }

        public void viewCote()
        {
            foreach (Cote item in coteList)
            {
                item.ShowInfoCote();
            }
        }

    }
}
