using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManagementSystem
{
    class Book : IBook
    {
        private int _ID;
        private string _Name;
        private string _PublishDate;
        private string _Author;
        private string _Language;
        private float _AveragePrice;
        private int[] _PriceList = new int[5];

        public int ID
        {
            get => this.ID;
            set => this.ID = this.ID++;
        }

        public string Name
        {
            get => this._Name;
            set => this._Name = value;
        }

        public string PublishDate
        {
            get => this._PublishDate;
            set => this._PublishDate = value;
        }

        public string Author 
        {
            get => this._Author;
            set => this._Author = value;
        }

        public string Language
        {
            get => this._Language;
            set => this._Language = value;
        }

        public float AveragePrice
        {
            get=> this._AveragePrice;
            private set => this.AveragePrice = Calculate();
        }
        
       
        private float Calculate()
        {
            float sum = 0;
;            for (int i=0;i<this._PriceList.Length;i++) 
            {
                sum += this._PriceList[i];
            }
            return sum / 5;
        }


        public void Display()
        {
            Console.WriteLine($"name={this.Name} date={this.PublishDate} author={this.Author} lang={this.Language} avg={this.AveragePrice}");
        }
    }
}
