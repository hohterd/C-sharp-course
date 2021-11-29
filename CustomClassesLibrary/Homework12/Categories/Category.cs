using CustomClassesLibrary.Homework12.Categories;
using System.Collections.Generic;
using System.Linq;

namespace CustomClassesLibrary.Homework12
{
    public abstract class Category
    {
        public static string CategoryName { get; set; }
        protected List<Data> Repository { get; set; } = new List<Data>();

        public virtual void AddNews(Data news)
        {
            Repository?.Add(news);
            NewsProvider.SendNewsByCategory(news.Category);
        }

        public virtual Data GetLatestNews()
        {
            return Repository?.Last();
        }
    }



}

