namespace gregslist_backend.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Location { get; set; }
        public string ImgUrl { get; set; }
    }
}