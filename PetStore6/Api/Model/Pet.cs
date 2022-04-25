namespace PetStore6.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> PhotoUrls { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public string Status { get; set; }

        public Pet(int id, Category category, string name, IEnumerable<string> photoUrls, IEnumerable<Tag> tags, string status)
        {
            Id = id;
            Category = category;
            Name = name;
            PhotoUrls = photoUrls;
            Tags = tags;
            Status = status;
        }
    }

}
