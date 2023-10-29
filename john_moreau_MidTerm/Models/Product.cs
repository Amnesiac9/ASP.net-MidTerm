using System.ComponentModel.DataAnnotations;

/*
* John Moreau
* CSS233
* 10/28/2023
*
*
*/

// Date Times Formatting for FORMS: https://www.mikesdotnetting.com/article/352/working-with-dates-and-times-in-razor-pages-forms#:~:text=Alternatively%2C%20you%20can%20use%20the%20asp-format%20attribute%20on,itself%3A%20DateTime%3A%20%3Cinput%20class%3D%22form-control%22%20asp-for%3D%22DateTime%22%20asp-format%3D%22%20%7B0%3Ayyyy-MM-ddTHH%3Amm%7D%22%20%2F%3E


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
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)] // SOURCE: https://www.mikesdotnetting.com/article/352/working-with-dates-and-times-in-razor-pages-forms#:~:text=Alternatively%2C%20you%20can%20use%20the%20asp-format%20attribute%20on,itself%3A%20DateTime%3A%20%3Cinput%20class%3D%22form-control%22%20asp-for%3D%22DateTime%22%20asp-format%3D%22%20%7B0%3Ayyyy-MM-ddTHH%3Amm%7D%22%20%2F%3E
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public string? DateAdded { get; set; } = string.Empty;


        public string? Slug => Name?.Replace(' ', '-').ToLower();
    }
}
