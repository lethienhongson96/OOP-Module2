using System;

namespace NewsManagement
{
    class Program
    {
        public static News NewsList = new News();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("press 1 to add new news!");
                Console.WriteLine("press 2 to see all news!");
                Console.WriteLine("press 3 to close");

                int checknum = Convert.ToInt32( Console.ReadLine());
                if (checknum==3)
                {
                    break;
                }
                switch (checknum)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        NewsList.ViewListNews();
                        break;
                }
            } while (true);

        }

        public static void add()
        {
            Console.Write("enter your title: ");
            string title=Console.ReadLine();

            Console.Write("enter your date: ");
            string date = Console.ReadLine();

            Console.Write("enter your author: ");
            string author = Console.ReadLine();

            Console.Write("enter your content: ");
            string content = Console.ReadLine();

            Console.Write("enter your first rate: ");
            int rate1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter your second rate: ");
            int rate2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter your third rate: ");
            int rate3 = Convert.ToInt32( Console.ReadLine());

            int[] RateList = { rate1, rate2, rate3 };

            News news = new News(title,date,author,content,RateList);

            NewsList.AddNews(news);
        }
    }
}
