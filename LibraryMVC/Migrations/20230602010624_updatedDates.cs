using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 1,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 2,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 3,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 4,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 5,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 6,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 1,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 2,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 3,
                columns: new[] { "BorrowedDate", "DueDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 4,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 5,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "BorrowedBookLists",
                keyColumn: "BorrowedBookListId",
                keyValue: 6,
                columns: new[] { "BorrowedDate", "DueDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996) });
        }
    }
}
