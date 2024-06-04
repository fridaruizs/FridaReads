namespace FridaReads.Server.Models
{
    public class TextModel
    {
        public string Name { get; set; }

        public string? Author { get; set; }

        public string? Description { get; set; }

        public DateTime? ReadDate { get; set; }

        public int? Stars { get; set; }

        public string? Review { get; set; }

        public int UserId { get; set; }
    }
}
