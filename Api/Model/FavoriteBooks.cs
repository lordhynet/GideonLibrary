namespace Api.Model
{
    public class FavoriteBooks : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }

        public string BookId { get; set; }
        public Books Book { get; set; }

        public bool IsFavorite { get; set; }
    }
}
