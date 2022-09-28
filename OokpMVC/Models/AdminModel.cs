using System.ComponentModel.DataAnnotations;

namespace OokpMVC.Models
{
    public class AdminModel
    {
        [Key]
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}