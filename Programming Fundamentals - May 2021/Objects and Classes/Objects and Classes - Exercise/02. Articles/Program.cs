using System;

namespace _02._Articles
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
            string[] input = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] newInput = Console.ReadLine().Split(": ");
                switch (newInput[0])
                {
                    case "Edit":
                        article.Edit(newInput[1].Trim());
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newInput[1].Trim());
                        break;
                    case "Rename":
                        article.Rename(newInput[1].Trim());
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    
}
