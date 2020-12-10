using System;
using System.Collections.Generic;
using System.Reflection;
using csharplibrary.db;
using csharplibrary.Models;

namespace csharplibrary.Services
{
  public class BookService
  {
    public IEnumerable<Book> GetALL()
    {
      return FakeDB.books;
    }

    public Book Create(Book newBook)
    {
      FakeDB.books.Add(newBook);
      return newBook;
    }

    public string Delete(int index)
    {
      FakeDB.books.RemoveAt(index);
      return "Book deleted!";
    }

    public Book Edit(int index, Book editedBook)
    {
      Book oldBook = FakeDB.books[index];

      //NOTE looping through an object and compares

      //   foreach (PropertyInfo prop in oldBook.GetType().GetProperties())
      //   {
      //     object oldValue = prop.GetValue(oldBook, null);
      //     object newValue = prop.GetValue(editedBook, null);
      //     if (!object.Equals(oldValue, newValue) && newValue != null)
      //     {
      //       oldValue = newValue;
      //       prop.SetValue(oldBook, newValue);
      //     }
      //   }

      //NOTE same function basically
      if (editedBook.Title != null)
      {
        oldBook.Title = editedBook.Title;
      }
      if (editedBook.Author != null)
      {
        oldBook.Author = editedBook.Author;
      }
      if (editedBook.Summary != null)
      {
        oldBook.Summary = editedBook.Summary;
      }
      if (editedBook.Pages != 0)
      {
        oldBook.Pages = editedBook.Pages;
      }
      return oldBook;
      //   FakeDB.books[index] = editedBook;
      //   return editedBook;
    }
  }
}