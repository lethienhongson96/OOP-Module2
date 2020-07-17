using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NewsManagement
{
    class News : INews
    {
        private int _Id;
        private string _Title;
        private string _PublishDate;
        private string _Author;
        private string _Content;
        private float _AverageRate=0;

        public News() { }

        public News(string title,string publishdate,string author,string content,int[] RateList)
        {
            this._Title = title;
            this._PublishDate = publishdate;
            this._Author = author;
            this._Content = content;
            this.Calculate(RateList);
            this.SetId();
        }

        News[] newsList = new News[0];

        public int GetId()
        {
            return this._Id;
        }

        public void SetId()
        {
            Random rnd = new Random();
            this._Id = rnd.Next(100,1000);
        }

        public string Title 
        {
            get => this._Title;
            set => this._Title = value;
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

        public string Content
        {
            get => this._Content;
            set => this._Content = value;
        }

        public float GetAverageRate() => this._AverageRate;

        private void Calculate(int[] Ratelist)
        {
            float Sum = 0;
            for (int i=0;i<Ratelist.Length;i++)
            {
                Sum += Ratelist[i];
            }

            this._AverageRate = Sum / Ratelist.Length;
        }

        public void AddNews(News news)
        {
            Array.Resize(ref newsList, newsList.Length + 1);
            newsList[newsList.Length - 1] = news;
        }

        public void ViewListNews()
        {
            foreach (News news in newsList)
            {
                news.DisPlay();
            }
        }

        public void DisPlay()
        {
            Console.WriteLine($"title={this.Title} date={this.PublishDate} author={this.Author} content={this.Content} avgRate={this.GetAverageRate()}");
        }
    }
}
