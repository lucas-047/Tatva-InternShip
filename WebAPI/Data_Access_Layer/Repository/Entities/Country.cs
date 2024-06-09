using System.ComponentModel.DataAnnotations;
namespace Data_Access_Layer.Repository.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string CountryName { get; set; }
    }

    public class City
    {
        [Key]   
        public int Id { get; set; }

        public int CountryId { get; set; }
        public string CityName { get; set; }
    }
}
