using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherWise.Entity
{
    [Table("Record")]
    public class Record
    {
        public int Id { get; set; }
        public int Temprature { get; set; }
        public int LocationId { get; set; }
        public int WeatherDescriptionId { get; set; }
    }
}
