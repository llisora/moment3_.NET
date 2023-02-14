using System.ComponentModel.DataAnnotations;

namespace AlbumDirectory.Models
{
    public class Artist
    {
        public int? ArtistId { get; set; }
        [Display(Name = "Namn på artist")]
        public string? Name { get; set; }

        public List<Album>? Albums { get; set; }
    }

    public class Album
    {
        public int? AlbumId { get; set; }
        [Display(Name = "Namn på album")]
        public string? Title { get; set; }
        public int? ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }

    public class User
    {
        public int? UserId { get; set; }
        [Display(Name = "Utlånad till")]
        public string? Name { get; set; }
        [Display(Name = "Datum för utlåning")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        public int? AlbumId { get; set; }
        public Album? Album { get; set; }
    }

}