using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class Books : BaseEntity
    {

        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public DateTime PublishedAt { get; set; }

        public string CategoryId { get; set; }
        public AppUser User { get; set; }
        public Category Category { get; set; }

        public List<FavoriteBooks> UserBooks { get; set; }

        public Books()
        {
            UserBooks = new List<FavoriteBooks>();
        }
    }
}



