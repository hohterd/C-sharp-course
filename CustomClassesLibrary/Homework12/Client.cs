using CustomClassesLibrary.Homework12.Categories;
using System;

namespace CustomClassesLibrary.Homework12
{
    public class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }

        public void GetLatestNews(Data data)
        {
            Console.WriteLine(data.News);
        }

        public void SubscribeForCategory(int number)
        {
            switch (number)
            {
                case 1:
                    NewsProvider.Humor += GetLatestNews;
                    break;
                case 2:
                    NewsProvider.Incidents += GetLatestNews;
                    break;
                case 3:
                    NewsProvider.News += GetLatestNews;
                    break;
                case 4:
                    NewsProvider.Sports += GetLatestNews;
                    break;
                case 5:
                    NewsProvider.Weather += GetLatestNews;
                    break;
            }
        }

    }
}
