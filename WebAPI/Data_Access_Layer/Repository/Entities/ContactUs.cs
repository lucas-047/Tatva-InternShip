using System.ComponentModel.DataAnnotations;
namespace Data_Access_Layer.Repository.Entities
{
    public class ContactUs : BaseEntity
    {
        [Key]
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
