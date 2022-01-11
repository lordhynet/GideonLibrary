using System.Collections.Generic;

namespace Api.Model
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public List<Books> Books { get; set; }

        public Category()
        {
            Books = new List<Books>();
        }
    }
}
