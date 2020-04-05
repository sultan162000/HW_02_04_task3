using System;

namespace HW_02_04_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1, text2, text3;
            System.Console.Write("Title: ");
            text1 = Console.ReadLine();
            System.Console.Write("Author: ");
            text2 = Console.ReadLine();
            System.Console.Write("Content book: ");
            text3 = Console.ReadLine();

            Book newBook = new Book(text1, text2, text3);   
            newBook.Show();
        }
    }

    class Book                                                                                          
        {           
            private Title title;                                                            
            private Author author;                                      
            private Content content;                                    

            public Book(string title, string author, string content)    
            {
                this.title = new Title(title);                          
                this.author = new Author(author); 
                this.content = new Content(content);                 
            }

            public void Show()             
            {
                title.Show();               
                author.Show();              
                content.Show();             
            }
        }
    class Title                                         
        {
            private string nameTitle { get; set; }          
            public Title (string nameTitle)                 
            {
                this.nameTitle = nameTitle;                 
            }
            public void Show()                                          
            {
                Console.ForegroundColor = ConsoleColor.Yellow;          
                System.Console.WriteLine($"Title: {this.nameTitle}");   
            }
        }
        
}
