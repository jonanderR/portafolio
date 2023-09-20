namespace Portafolio.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Link { get; set; }

        public Project(string title, string description, string imageURL, string link)
        {
            Title = title;
            Description = description;
            ImageURL = imageURL;
            Link = link;
        }
    }
}
