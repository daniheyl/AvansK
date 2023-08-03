namespace Portal.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool ContainsAlcohol { get; set; }

        public string Picture { get; set; }

    }
}
