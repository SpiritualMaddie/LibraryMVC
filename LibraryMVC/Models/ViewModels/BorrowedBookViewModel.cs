using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LibraryMVC.Models.ViewModels
{
    public class BorrowedBookViewModel
    {
        public int CustomerId { get; set; } = 0;

        [DisplayName("Name")]
        public string FullName { get; set; } = default!;

        public string ISBN { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Author { get; set; } = default!;
        public string Language { get; set; } = default!;
        public string? BookImgUrl { get; set; } = default!;


        public int BorrowedBookListId { get; set; } = 0;
        [DisplayName("Book returned?")]
        public bool Returned { get; set; } = false;

        [DisplayName("Returned at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ReturnedDate { get; set; }

        [DisplayName("Due date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(21);

        [DisplayName("Borrowed at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BorrowedDate { get; set; } = DateTime.Now;

    }
}
