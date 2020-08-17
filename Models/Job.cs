namespace gregslist_backend.Models
{
    public class Job
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }
        public float Rate { get; set; }
        public string ImgUrl { get; set; }
    }
}