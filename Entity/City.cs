using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Entity
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public string Country { get; set; } 
        public IList<Forecast> Forecasts { get; set; }
    }
}
