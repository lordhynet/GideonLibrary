using Api.Model;
using System;

namespace Api.DTOs
{
    public class BookDto : BaseEntity
    {

        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public string CoverUrl { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
