namespace tree_example;

public class Book {
    public string Title {get; set;}
    public string Author {get; set;}
    public int PubYear {get; set;}

    public Book(string title, string author, int year) {
        this.Title = title;
        this.Author = author;
        this.PubYear = year;
    }

    public override string ToString() {
        return "<Book>{" + "Title: " + this.Title + ", Author: " + this.Author + ", Year: " + this.PubYear +"}";
    }
}