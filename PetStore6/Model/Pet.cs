namespace PetStore6.Models
{
    public class Pet
    {
        public int Id;
        public Category Category { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> PhotoUrls { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public string Status { get; set; }
    }
}
