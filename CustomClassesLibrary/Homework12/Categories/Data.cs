using System;
namespace CustomClassesLibrary.Homework12.Categories
{
    public class Data
    {
        public DateTime DateTime { get; set; }
        public string News { get; set; }
        public Category Category { get; set; }

        public Data(Category category, string news)
        {
            DateTime = DateTime.Now;
            News = news;
            Category = category;
        }
    }
}
