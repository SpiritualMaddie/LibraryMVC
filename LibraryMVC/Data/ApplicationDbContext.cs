using LibraryMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBookList> BorrowedBookLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer
                    {
                        CustomerId = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Phone = "1234567890",
                        Email = "john@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 2,
                        FirstName = "Jane",
                        LastName = "Smith",
                        Phone = "9876543210",
                        Email = "jane@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 3,
                        FirstName = "Michael",
                        LastName = "Johnson",
                        Phone = "5555555555",
                        Email = "michael@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 4,
                        FirstName = "Emily",
                        LastName = "Brown",
                        Phone = "1111111111",
                        Email = "emily@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 5,
                        FirstName = "Daniel",
                        LastName = "Davis",
                        Phone = "9999999999",
                        Email = "daniel@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 6,
                        FirstName = "Olivia",
                        LastName = "Taylor",
                        Phone = "2222222222",
                        Email = "olivia@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 7,
                        FirstName = "James",
                        LastName = "Clark",
                        Phone = "7777777777",
                        Email = "james@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 8,
                        FirstName = "Sophia",
                        LastName = "Lewis",
                        Phone = "3333333333",
                        Email = "sophia@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 9,
                        FirstName = "David",
                        LastName = "Walker",
                        Phone = "8888888888",
                        Email = "david@example.com"
                    },
                    new Customer
                    {
                        CustomerId = 10,
                        FirstName = "Emma",
                        LastName = "Wilson",
                        Phone = "4444444444",
                        Email = "emma@example.com"
                    }
                );

            modelBuilder.Entity<Book>()
                .HasData(
                    new Book
                    {
                        ISBN = "9781847498571",
                        Title = "1984",
                        Author = "George Orwell",
                        Pages = 400,
                        Language = "English",
                        PublishedDate = new DateTime(2021, 1, 7),
                        Publisher = "Alma Classics",
                        BookImgUrl = "https://image.bokus.com/images/9781847498571_200x_1984-nineteen-eighty-four_haftad"
                    },
                    new Book
                    {
                        ISBN = "9780061120084",
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        Pages = 336,
                        Language = "English",
                        PublishedDate = new DateTime(1960, 7, 11),
                        Publisher = "Harper Perennial Modern Classics",
                        BookImgUrl = "https://image.bokus.com/images/9780061120084_200x_to-kill-a-mockingbird_haftad"
                    },
                    new Book
                    {
                        ISBN = "9780786222728",
                        Title = "Harry Potter and the Sorcerer's Stone",
                        Author = "J.K. Rowling",
                        Pages = 424,
                        Language = "English",
                        PublishedDate = new DateTime(1999, 11, 1),
                        Publisher = "Thorndike Press Large Print",
                        BookImgUrl = "https://s1.adlibris.com/images/4410077/harry-potter-and-the-sorcerers-stone.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780743273565",
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Pages = 180,
                        Language = "English",
                        PublishedDate = new DateTime(2004, 10, 1),
                        Publisher = "Scribner",
                        BookImgUrl = "https://s2.adlibris.com/images/2143197/great-gatsby-the-us-import-ed.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780141199078",
                        Title = "Pride and Prejudice",
                        Author = "Jane Austen",
                        Pages = 416,
                        Language = "English",
                        PublishedDate = new DateTime(2012, 12, 6),
                        Publisher = "Penguin Books Ltd.",
                        BookImgUrl = "https://s1.adlibris.com/images/50780/pride-and-prejudice.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780007458424",
                        Title = "The Hobbit",
                        Author = "J.R.R. Tolkien",
                        Pages = 368,
                        Language = "English",
                        PublishedDate = new DateTime(2012, 6, 7),
                        Publisher = "HARPERCOLLINS PUBLISHERS",
                        BookImgUrl = "https://s1.adlibris.com/images/2764059/the-hobbit.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780316769488",
                        Title = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        Pages = 240,
                        Language = "English",
                        PublishedDate = new DateTime(1991, 5, 1),
                        Publisher = "Little, Brown and Company",
                        BookImgUrl = "https://s1.adlibris.com/images/658340/the-catcher-in-the-rye.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780006546061",
                        Title = "Fahrenheit 451",
                        Author = "Ray Bradbury",
                        Pages = 192,
                        Language = "English",
                        PublishedDate = new DateTime(1993, 8, 1),
                        Publisher = "Harper Voyager",
                        BookImgUrl = "https://image.bokus.com/images/9780006546061_200x_fahrenheit-451_haftad"
                    },
                    new Book
                    {
                        ISBN = "9780060254926",
                        Title = "Where the Wild Things Are",
                        Author = "Maurice Sendak",
                        Pages = 32,
                        Language = "English",
                        PublishedDate = new DateTime(2012, 12, 26),
                        Publisher = "HarperCollins Children's Books",
                        BookImgUrl = "https://s1.adlibris.com/images/961645/where-the-wild-things-are.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780441172719",
                        Title = "Dune",
                        Author = "Frank Herbert",
                        Pages = 896,
                        Language = "English",
                        PublishedDate = new DateTime(1965, 8, 1),
                        Publisher = "Ace Books",
                        BookImgUrl = "https://pictures.abebooks.com/isbn/9780441172719-us.jpg"
                    },
                    new Book
                    {
                        ISBN = "9789113071299",
                        Title = "Män som hatar kvinnor",
                        Author = "Stieg Larsson",
                        Pages = 567,
                        Language = "Swedish",
                        PublishedDate = new DateTime(2015, 9, 21),
                        Publisher = "Norstedts Förlag",
                        BookImgUrl = "https://s1.adlibris.com/images/20938473/man-som-hatar-kvinnor.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780061122415",
                        Title = "The Alchemist",
                        Author = "Paulo Coelho",
                        Pages = 208,
                        Language = "Portuguese",
                        PublishedDate = new DateTime(1988, 1, 1),
                        Publisher = "HarperOne",
                        BookImgUrl = "https://m.media-amazon.com/images/I/41ybG235TcL._SX329_BO1,204,203,200_.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780316055444",
                        Title = "The Goldfinch",
                        Author = "Donna Tartt",
                        Pages = 784,
                        Language = "English",
                        PublishedDate = new DateTime(2015, 4, 1),
                        Publisher = "Back Bay Books",
                        BookImgUrl = "https://s2.adlibris.com/images/2756455/the-goldfinch-a-novel-pulitzer-prize-for-fiction.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780446310789",
                        Title = "Där askan blommar",
                        Author = "Phan Que Mai Nguyen",
                        Pages = 408,
                        Language = "Swedish",
                        PublishedDate = new DateTime(2023, 4, 24),
                        Publisher = "Historiska Media",
                        BookImgUrl = "https://s2.adlibris.com/images/64998400/dar-askan-blommar.jpg"
                    },
                    new Book
                    {
                        ISBN = "9781501180989",
                        Title = "The Outsider",
                        Author = "Stephen King",
                        Pages = 576,
                        Language = "English",
                        PublishedDate = new DateTime(2018, 5, 1),
                        Publisher = "Scribner Book Company",
                        BookImgUrl = "https://s1.adlibris.com/images/35482045/the-outsider.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780439023528",
                        Title = "The Hunger Games",
                        Author = "Suzanne Collins",
                        Pages = 384,
                        Language = "English",
                        PublishedDate = new DateTime(2010, 7, 1),
                        Publisher = "Scholastic Press",
                        BookImgUrl = "https://s1.adlibris.com/images/780283/the-hunger-games-hunger-games-book-one-volume-1.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780553103540",
                        Title = "A Game of Thrones",
                        Author = "George R.R. Martin",
                        Pages = 704,
                        Language = "English",
                        PublishedDate = new DateTime(1996, 8, 1),
                        Publisher = "Bantam Books",
                        BookImgUrl = "https://s1.adlibris.com/images/206629/a-game-of-thrones.jpg"
                    },
                    new Book
                    {
                        ISBN = "9781035003792",
                        Title = "The Road",
                        Author = "Cormac McCarthy",
                        Pages = 336,
                        Language = "English",
                        PublishedDate = new DateTime(2022, 8, 04),
                        Publisher = "Vintage International",
                        BookImgUrl = "https://s2.adlibris.com/images/63511627/the-road.jpg"
                    },
                    new Book
                    {
                        ISBN = "9780141315195",
                        Title = "The Diary of a Young Girl",
                        Author = "Anne Frank",
                        Pages = 464,
                        Language = "Dutch",
                        PublishedDate = new DateTime(1947, 6, 25),
                        Publisher = "Penguin Books",
                        BookImgUrl = "https://s1.adlibris.com/images/1630222/the-diary-of-a-young-girl.jpg"
                    },
                    new Book
                    {
                        ISBN = "9781526604736",
                        Title = "The Kite Runner",
                        Author = "Khaled Hosseini",
                        Pages = 372,
                        Language = "English",
                        PublishedDate = new DateTime(2003, 5, 29),
                        Publisher = "Riverhead Books",
                        BookImgUrl = "https://s2.adlibris.com/images/44037491/kite-runner.jpg"
                    },
                    new Book
                    {
                        ISBN = "9781784161101",
                        Title = "The Girl on the Train",
                        Author = "Paula Hawkins",
                        Pages = 416,
                        Language = "English",
                        PublishedDate = new DateTime(2015, 1, 13),
                        Publisher = "Random House UK",
                        BookImgUrl = "https://s2.adlibris.com/images/21218791/girl-on-the-train.jpg"
                    },
                    new Book
                    {
                        ISBN = "9789100184728",
                        Title = "Institutet ",
                        Author = "Stephen King",
                        Pages = 664,
                        Language = "Swedish",
                        PublishedDate = new DateTime(2020, 7, 7),
                        Publisher = "Albert Bonniers Förlag",
                        BookImgUrl = "https://s1.adlibris.com/images/58348667/institutet.jpg"
                    }
                );

            modelBuilder.Entity<BorrowedBookList>()
                .HasData(
                new BorrowedBookList
                {
                    BorrowedBookListId = 1,
                    FK_ISBN = "9789100184728",
                    FK_CustomerId = 1,
                    BorrowedDate = new DateTime(2023, 01, 02),
                    ReturnedDate = new DateTime(2023, 02, 10),
                    DueDate = new DateTime(2023, 02, 23),
                    Returned = true
                },
                new BorrowedBookList
                {
                    BorrowedBookListId = 2,
                    FK_ISBN = "9781784161101",
                    FK_CustomerId = 2,
                    BorrowedDate = new DateTime(2020, 01, 02),
                    ReturnedDate = new DateTime(2020, 02, 10),
                    DueDate = new DateTime(2020, 02, 23),
                    Returned = true
                },
                new BorrowedBookList
                {
                    BorrowedBookListId = 3,
                    FK_ISBN = "9781526604736",
                    FK_CustomerId = 3,
                    BorrowedDate = new DateTime(2022, 02, 02),
                    ReturnedDate = new DateTime(2022, 03, 10),
                    DueDate = new DateTime(2022, 03, 23),
                    Returned = true
                },
                new BorrowedBookList
                {
                    BorrowedBookListId = 4,
                    FK_ISBN = "9780439023528",
                    FK_CustomerId = 4,
                    BorrowedDate = new DateTime(2023, 05, 25),
                    DueDate = new DateTime(2023, 06, 16),
                    Returned = false
                },
                new BorrowedBookList
                {
                    BorrowedBookListId = 5,
                    FK_ISBN = "9780316055444",
                    FK_CustomerId = 5,
                    BorrowedDate = new DateTime(2023, 05, 20),
                    DueDate = new DateTime(2023, 06, 11),
                    Returned = false
                },
                new BorrowedBookList
                {
                    BorrowedBookListId = 6,
                    FK_ISBN = "9789113071299",
                    FK_CustomerId = 1,
                    BorrowedDate = new DateTime(2023, 05, 30),
                    DueDate = new DateTime(2023, 06, 21),
                    Returned = false
                }
                );
        }
    }
}
