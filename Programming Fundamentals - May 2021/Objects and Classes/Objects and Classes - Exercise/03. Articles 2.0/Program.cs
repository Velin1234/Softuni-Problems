using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }

            string order = Console.ReadLine();
            List<Article> orderedArticles = new List<Article>();
            switch (order)
            {
                case "title":
                orderedArticles = articles.OrderBy(a => a.Title).ToList();
                    break;

                case "content":
                 orderedArticles = articles.OrderBy(a => a.Content).ToList();
                    break;

                case "author":
                   orderedArticles = articles.OrderBy(a => a.Author).ToList();
                    break;
            }

            foreach (var article in orderedArticles)
            {
                Console.WriteLine(article.ToString()); 
            }
        }
    }
}
