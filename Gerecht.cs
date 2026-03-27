namespace Sushi_afhaalwebsite.Models
{
    public class Gerecht
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }
        public string Ingredienten { get; set; }
        public int AantalStuks { get; set; }
    }
}
