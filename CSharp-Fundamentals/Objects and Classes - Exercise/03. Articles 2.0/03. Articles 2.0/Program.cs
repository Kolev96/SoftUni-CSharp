using System;
using System.Collections.Generic;

namespace ConsoleApp108
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ");
                var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                articles.Add(article);

            }

            string line = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }

        }


    }

    class Article
    {

        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public void Rename(string title) => Title = title;

        public void Edit(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}