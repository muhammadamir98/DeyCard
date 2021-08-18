namespace DeyCard_MVC.Models
{
    public class Projects
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { get; set; }
        public string Client { set; get; }

        public Projects(long id, string name, string description, string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}