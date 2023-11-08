using System.ComponentModel.DataAnnotations;

namespace Atelje_Konstram.ViewModels
{
    public class PageContactFormViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;


        [Required]
        [MaxLength(10000)]
        public string Message { get; set; } = string.Empty;


        public string Title { get; set; } = string.Empty;
        public string PageInfo { get; set; } = string.Empty;
    }
}
