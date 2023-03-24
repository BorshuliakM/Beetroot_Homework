using Lesson;


Book Book1 = new(0, "Some fiction", new List<string>() { "Adventure", "Fiction" }, "Famous Author");
Author Author1 = new(0, "Famous_Author", new List<Book>() { Book1 });
Book_library Somelibrary = new("library_1", new List<Book>() { Book1 }, new List<Author>() { Author1 });
//Book1.PrintBook();
//Author1.PrintAuthor();
Somelibrary.Print();
