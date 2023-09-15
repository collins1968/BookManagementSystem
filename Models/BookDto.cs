using System.ComponentModel.DataAnnotations;

namespace BlazorFrontend.Models
{
    public class BookDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]

        public string Description { get; set; } = string.Empty;


        public List<AuthorDto> Authors { get; set; } = new List<AuthorDto>();

    }
}
