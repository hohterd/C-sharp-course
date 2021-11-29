using CustomClassesLibrary.Homework12.Categories;
using System;

namespace CustomClassesLibrary.Homework12
{
    public static class NewsProvider
    {
        public static event Action<Data> Humor;
        public static event Action<Data> Incidents;
        public static event Action<Data> News;
        public static event Action<Data> Sports;
        public static event Action<Data> Weather;

        public static void SendNewsByCategory(Category category)
        {
            switch (category)
            {
                case Humor _:
                    Humor?.Invoke(category.GetLatestNews());
                    break;
                case Incidents _:
                    Incidents?.Invoke(category.GetLatestNews());
                    break;
                case News _:
                    News?.Invoke(category.GetLatestNews());
                    break;
                case Sports _:
                    Sports?.Invoke(category.GetLatestNews());
                    break;
                case Weather _:
                    Weather?.Invoke(category.GetLatestNews());
                    break;
                default:
                    break;

            }
        }

    }
}
