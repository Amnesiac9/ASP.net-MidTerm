using System.ComponentModel.DataAnnotations;

/*
* John Moreau
* CSS233
* 10/28/2023
*
*
*/


namespace john_moreau_MidTerm.Models
{
    public class Product
    {
        // EF Core will configure the database to generate this value
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a Product Code")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid Price")]
        //[RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid 10-digit phone number in format 555-555-5555.")]
        public decimal Price { get; set; } = 0.00M;

        [Required(ErrorMessage = "Please enter a Release Date")]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        //[Required(ErrorMessage = "Category ID Required")]
        //[Range(1, double.PositiveInfinity, ErrorMessage = "Category ID must be greater than 0")]
        //public int CategoryId { get; set; }
        //public Category? Category { get; set; } // Navigation property

        public string? DateAdded { get; set; } = string.Empty;


        public string? Slug => Name?.Replace(' ', '-').ToLower(); //+ '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
