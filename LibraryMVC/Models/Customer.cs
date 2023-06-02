using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LibraryMVC.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; } = 0;

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50)]
        [DisplayName("First name")]
        public string FirstName { get; set; } = default!;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(30)]
        [DisplayName("Last name")]
        public string LastName { get; set; } = default!;

        [NotMapped]
        [DisplayName("Name")]
        public string FullName => (FirstName + " " + LastName);

        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(20)]
        public string Phone { get; set; } = default!;

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50)]
        public string Email { get; set; } = default!;


        public virtual ICollection<BorrowedBookList>? BorrowedBookLists { get; set; }
    }
}
