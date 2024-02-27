using System;
using System.Collections.Generic;
using System.IO;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({PublicationYear})";
    }
}

public class BookManager
{
    private List<Book> books = new List<Book>();
    private string filePath;

    public BookManager(string filePath)
    {
        this.filePath = filePath;
        LoadBooks();
    }

    private void LoadBooks()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string title = parts[0].Trim();
                    string author = parts[1].Trim();
                    int year;
                    if (int.TryParse(parts[2].Trim(), out year))
                    {
                        books.Add(new Book { Title = title, Author = author, PublicationYear = year });
                    }
                }
            }
        }
    }

    private void SaveBooks()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Book book in books)
            {
                writer.WriteLine($"{book.Title},{book.Author},{book.PublicationYear}");
            }
        }
    }

    public void AddBook(string title, string author, int publicationYear)
    {
        Console.Clear();
        var book = new Book { Title = title, Author = author, PublicationYear = publicationYear };
        books.Add(book);
        SaveBooks();
        Console.WriteLine("Book added successfully!");

    }

    public void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the list.");
            return;
        }
        Console.Clear();
        Console.WriteLine("List of Books:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void SearchBook(string title)
    {
        string filePath = @"C:\Users\kacha\OneDrive\Desktop\HTM.CSS.JS\Final Projects\books.txt";
        List<Book> foundBooks = new List<Book>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string bookTitle = parts[0].Trim();
                    string author = parts[1].Trim();
                    int year;
                    if (int.TryParse(parts[2].Trim(), out year) && bookTitle.Contains(title))
                    {
                        foundBooks.Add(new Book { Title = bookTitle, Author = author, PublicationYear = year });
                    }
                }
            }
        }

        if (foundBooks.Count == 0)
        {
            Console.WriteLine("No books found with the given title.");
            return;
        }

        Console.WriteLine("Found Books:");
        foreach (var book in foundBooks)
        {
            Console.WriteLine(book);
        }
    }

    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\kacha\OneDrive\Desktop\HTM.CSS.JS\Final Projects\books.txt";
            BookManager bookManager = new BookManager(filePath);
            while (true)
            {
                Console.WriteLine("\nBook Management System\n");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search for a book by title");
                Console.WriteLine("4. Exit\n");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter publication year: ");
                        int publicationYear;
                        if (!int.TryParse(Console.ReadLine(), out publicationYear))
                        {
                            Console.WriteLine("Invalid publication year. Please enter a number.");
                            continue;
                        }
                        bookManager.AddBook(title, author, publicationYear);
                        break;
                    case 2:
                        bookManager.DisplayBooks();
                        break;
                    case 3:
                        Console.Write("Enter book title to search: ");
                        string searchTitle = Console.ReadLine();
                        bookManager.SearchBook(searchTitle);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}