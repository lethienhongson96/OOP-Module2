using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Cote
    {
        #region properties
        private int _Id;
        #endregion

        public Cote()
        {
            SetId();
        }

        ArrayList animalList = new ArrayList();

        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }

        public int ID=> this._Id;

        public void SetId()
        {
            Random rnd = new Random();
            this._Id = rnd.Next(100,1000);
        }

        public void DeleteAnimal(int idAnimal)
        {
            if (FindIndex(idAnimal) != -1)
            {
                animalList.RemoveAt(FindIndex(idAnimal));
            }

            else {
                Console.WriteLine("not found!");
            }
        }

        public int FindIndex(int idAnimal)
        {
            int i = -1;
            foreach (Animal item in animalList)
            {
                i++;
                if (item.ID == idAnimal)
                {
                    return i;
                }
            }
            return -1;
        }

        public void ShowInfoCote()
        {
            Console.WriteLine($"id: {this.ID}");
        }

        public void SoundOfAnimal()
        {
            foreach (Animal item in animalList)
            {
                item.Sound();
            }
        }

    }
}
