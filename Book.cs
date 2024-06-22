namespace myConsoleApp
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(string argAuthor, string argTitle)
        {
            Author = argAuthor;
            Title = argTitle;
        }

        public void Run()
        {
            Console.WriteLine($"Author: {Author}, Title: {Title}");
        }
    }
}
