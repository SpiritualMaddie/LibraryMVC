using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Models
{
    public class Book
    {
        [Key]
        [Required(ErrorMessage = "ISBN is required.")]
        [MaxLength(20)]
        //[RegularExpression(@"^\d{10,13}$", ErrorMessage = "ISBN must be between 10 and 13 numbers")]
        public string ISBN { get; set; } = default!;

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(150)]
        public string Title { get; set; } = default!;

        [Required(ErrorMessage = "Author is required.")]
        [MaxLength(150)]
        public string Author { get; set; } = default!;

        [MaxLength(5)]
        public int? Pages { get; set; }

        [Required(ErrorMessage = "Language is required.")]
        [MaxLength(50)]
        public string Language { get; set; } = default!;

        [DisplayName("Published")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PublishedDate { get; set; }

        [Required(ErrorMessage = "Publisher is required.")]
        [MaxLength(150)]
        public string Publisher { get; set; } = default!;

        [MaxLength(500)]
        public string? BookImgUrl { get; set; }
        public virtual ICollection<BorrowedBookList>? BorrowedBookLists { get; set; }
    }
}
