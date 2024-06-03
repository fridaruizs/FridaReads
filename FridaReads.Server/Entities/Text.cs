namespace FridaReads.Server.Entities
{
    public class Text
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime ReadDate { get; set; }

        public int Stars { get; set; }

        public string Review { get; set; }
    }
}
