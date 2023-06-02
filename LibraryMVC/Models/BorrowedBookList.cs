using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMVC.Models
{
    public class BorrowedBookList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowedBookListId { get; set; } = 0;

        [Required(ErrorMessage = "Customer id is required.")]
        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; } = 0;
        public virtual Customer? Customers { get; set; }

        [Required(ErrorMessage = "ISBN is required.")]
        [ForeignKey("Book")]
        public string FK_ISBN { get; set; } = default!;
        public virtual Book? Books { get; set; }

        [Required(ErrorMessage = "Borrowed date is required.")]
        [DisplayName("Borrowed at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BorrowedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Due date is required.")]
        [DisplayName("Due date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(21);

        [DisplayName("Returned at")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ReturnedDate { get; set; } = default!;

        [Required(ErrorMessage = "Returned, yes or no, is required.")]
        [DisplayName("Book returned?")]
        public bool Returned { get; set; } = false;

    }
}
