using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class testNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Pages = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BookImgUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBookLists",
                columns: table => new
                {
                    BorrowedBookListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomersCustomerId = table.Column<int>(type: "int", nullable: true),
                    FK_ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BooksISBN = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    BorrowedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Returned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBookLists", x => x.BorrowedBookListId);
                    table.ForeignKey(
                        name: "FK_BorrowedBookLists_Books_BooksISBN",
                        column: x => x.BooksISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN");
                    table.ForeignKey(
                        name: "FK_BorrowedBookLists_Customers_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "BookImgUrl", "Language", "Pages", "PublishedDate", "Publisher", "Title" },
                values: new object[,]
                {
                    { "9780006546061", "Ray Bradbury", "https://image.bokus.com/images/9780006546061_200x_fahrenheit-451_haftad", "English", 192, new DateTime(1993, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harper Voyager", "Fahrenheit 451" },
                    { "9780007458424", "J.R.R. Tolkien", "https://s1.adlibris.com/images/2764059/the-hobbit.jpg", "English", 368, new DateTime(2012, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HARPERCOLLINS PUBLISHERS", "The Hobbit" },
                    { "9780060254926", "Maurice Sendak", "https://s1.adlibris.com/images/961645/where-the-wild-things-are.jpg", "English", 32, new DateTime(2012, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "HarperCollins Children's Books", "Where the Wild Things Are" },
                    { "9780061120084", "Harper Lee", "https://image.bokus.com/images/9780061120084_200x_to-kill-a-mockingbird_haftad", "English", 336, new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harper Perennial Modern Classics", "To Kill a Mockingbird" },
                    { "9780061122415", "Paulo Coelho", "https://m.media-amazon.com/images/I/41ybG235TcL._SX329_BO1,204,203,200_.jpg", "Portuguese", 208, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HarperOne", "The Alchemist" },
                    { "9780141199078", "Jane Austen", "https://s1.adlibris.com/images/50780/pride-and-prejudice.jpg", "English", 416, new DateTime(2012, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Books Ltd.", "Pride and Prejudice" },
                    { "9780141315195", "Anne Frank", "https://s1.adlibris.com/images/1630222/the-diary-of-a-young-girl.jpg", "Dutch", 464, new DateTime(1947, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penguin Books", "The Diary of a Young Girl" },
                    { "9780316055444", "Donna Tartt", "https://s2.adlibris.com/images/2756455/the-goldfinch-a-novel-pulitzer-prize-for-fiction.jpg", "English", 784, new DateTime(2015, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back Bay Books", "The Goldfinch" },
                    { "9780316769488", "J.D. Salinger", "https://s1.adlibris.com/images/658340/the-catcher-in-the-rye.jpg", "English", 240, new DateTime(1991, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little, Brown and Company", "The Catcher in the Rye" },
                    { "9780439023528", "Suzanne Collins", "https://s1.adlibris.com/images/780283/the-hunger-games-hunger-games-book-one-volume-1.jpg", "English", 384, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scholastic Press", "The Hunger Games" },
                    { "9780441172719", "Frank Herbert", "https://pictures.abebooks.com/isbn/9780441172719-us.jpg", "English", 896, new DateTime(1965, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ace Books", "Dune" },
                    { "9780446310789", "Phan Que Mai Nguyen", "https://s2.adlibris.com/images/64998400/dar-askan-blommar.jpg", "Swedish", 408, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Historiska Media", "Där askan blommar" },
                    { "9780553103540", "George R.R. Martin", "https://s1.adlibris.com/images/206629/a-game-of-thrones.jpg", "English", 704, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bantam Books", "A Game of Thrones" },
                    { "9780743273565", "F. Scott Fitzgerald", "https://s2.adlibris.com/images/2143197/great-gatsby-the-us-import-ed.jpg", "English", 180, new DateTime(2004, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scribner", "The Great Gatsby" },
                    { "9780786222728", "J.K. Rowling", "https://s1.adlibris.com/images/4410077/harry-potter-and-the-sorcerers-stone.jpg", "English", 424, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thorndike Press Large Print", "Harry Potter and the Sorcerer's Stone" },
                    { "9781035003792", "Cormac McCarthy", "https://s2.adlibris.com/images/63511627/the-road.jpg", "English", 336, new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vintage International", "The Road" },
                    { "9781501180989", "Stephen King", "https://s1.adlibris.com/images/35482045/the-outsider.jpg", "English", 576, new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scribner Book Company", "The Outsider" },
                    { "9781526604736", "Khaled Hosseini", "https://s2.adlibris.com/images/44037491/kite-runner.jpg", "English", 372, new DateTime(2003, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riverhead Books", "The Kite Runner" },
                    { "9781784161101", "Paula Hawkins", "https://s2.adlibris.com/images/21218791/girl-on-the-train.jpg", "English", 416, new DateTime(2015, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Random House UK", "The Girl on the Train" },
                    { "9781847498571", "George Orwell", "https://image.bokus.com/images/9781847498571_200x_1984-nineteen-eighty-four_haftad", "English", 400, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alma Classics", "1984" },
                    { "9789100184728", "Stephen King", "https://s1.adlibris.com/images/58348667/institutet.jpg", "Swedish", 664, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert Bonniers Förlag", "Institutet " },
                    { "9789113071299", "Stieg Larsson", "https://s1.adlibris.com/images/20938473/man-som-hatar-kvinnor.jpg", "Swedish", 567, new DateTime(2015, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norstedts Förlag", "Män som hatar kvinnor" }
                });

            migrationBuilder.InsertData(
                table: "BorrowedBookLists",
                columns: new[] { "BorrowedBookListId", "BooksISBN", "BorrowedDate", "CustomersCustomerId", "DueDate", "FK_CustomerId", "FK_ISBN", "Returned", "ReturnedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), 1, "9789100184728", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), 2, "9781784161101", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), 3, "9781526604736", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2001), 4, "9780439023528", false, null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2006), 5, "9780316055444", false, null },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), 1, "9789113071299", false, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John", "Doe", "1234567890" },
                    { 2, "jane@example.com", "Jane", "Smith", "9876543210" },
                    { 3, "michael@example.com", "Michael", "Johnson", "5555555555" },
                    { 4, "emily@example.com", "Emily", "Brown", "1111111111" },
                    { 5, "daniel@example.com", "Daniel", "Davis", "9999999999" },
                    { 6, "olivia@example.com", "Olivia", "Taylor", "2222222222" },
                    { 7, "james@example.com", "James", "Clark", "7777777777" },
                    { 8, "sophia@example.com", "Sophia", "Lewis", "3333333333" },
                    { 9, "david@example.com", "David", "Walker", "8888888888" },
                    { 10, "emma@example.com", "Emma", "Wilson", "4444444444" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBookLists_BooksISBN",
                table: "BorrowedBookLists",
                column: "BooksISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBookLists_CustomersCustomerId",
                table: "BorrowedBookLists",
                column: "CustomersCustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBookLists");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
