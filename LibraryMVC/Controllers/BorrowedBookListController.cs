using LibraryMVC.Data;
using LibraryMVC.Models;
using LibraryMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryMVC.Controllers
{
    public class BorrowedBookListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BorrowedBookListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers borrowed books
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult<BorrowedBookViewModel>> GetBorrowedBooks(string searchString)
        {

            List<BorrowedBookViewModel> borrowedBookList = new List<BorrowedBookViewModel>();

            var borrowedBooks = await (from bb in _context.BorrowedBookLists
                                       join c in _context.Customers on bb.FK_CustomerId equals c.CustomerId
                                       join b in _context.Books on bb.FK_ISBN equals b.ISBN
                                       select new BorrowedBookViewModel
                                       {
                                           CustomerId = c.CustomerId,
                                           FullName = c.FirstName + " " + c.LastName,
                                           ISBN = b.ISBN,
                                           Title = b.Title,
                                           Author = b.Author,
                                           Language = b.Language,
                                           BookImgUrl = b.BookImgUrl,
                                           ReturnedDate = bb.ReturnedDate,
                                           Returned = bb.Returned,
                                           BorrowedDate = bb.BorrowedDate,
                                           DueDate = bb.DueDate
                                       }).ToListAsync();


            foreach (var item in borrowedBooks)
            {
                BorrowedBookViewModel books = new BorrowedBookViewModel();

                books.FullName = item.FullName;
                books.CustomerId = item.CustomerId;
                books.ISBN = item.ISBN;
                books.Title = item.Title;
                books.Author = item.Author;
                books.Language = item.Language;
                books.BookImgUrl = item.BookImgUrl;
                books.ReturnedDate = item.ReturnedDate;
                books.Returned = item.Returned;
                books.BorrowedDate = item.BorrowedDate;
                books.DueDate = item.BorrowedDate.AddDays(21);

                borrowedBookList.Add(books);
            }

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                borrowedBooks = borrowedBooks
                    .Where(s => s.FullName
                    .StartsWith(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return View(borrowedBooks);
        }

        public async Task<ActionResult<BorrowedBookList>> BorrowBook(string ISBN)
        {
            if (ISBN == null)
            {
                return NotFound();
            }

            var bookInfo = await _context.Books
                .Where(b => b.ISBN == ISBN).ToListAsync();

            if (bookInfo == null)
            {
                return NotFound();
            }


            ViewBag.bookImg = await _context.Books
                .Where(b => b.ISBN == ISBN)
                .Select(b => b.BookImgUrl)
                .FirstOrDefaultAsync();

            TempData["FK_ISBN"] = ISBN;


            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<BorrowedBookList>> BorrowBookPOST(string FK_ISBN, int FK_CustomerId)
        {
            
            
            if (ModelState.IsValid)
            {
                var borrowedBook = new BorrowedBookList
                {
                    FK_ISBN = FK_ISBN,
                    FK_CustomerId = FK_CustomerId,
                    Returned = false
                };

                _context.BorrowedBookLists.Add(borrowedBook);
                await _context.SaveChangesAsync();

                TempData["ISBN"] = borrowedBook.FK_ISBN;
                TempData["SuccessMessage"] = "Book has been borrowed";

                return RedirectToAction("Details", "Book");
            }
            else
            {
                TempData["ErrorMessage"] = "Something went wrong";
                return RedirectToAction("BorrowBook");
            }
        }
    }
}
