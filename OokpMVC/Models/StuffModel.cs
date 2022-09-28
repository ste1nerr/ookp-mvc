using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OokpMVC.Models
{
    public class StuffModel
    {
        protected StuffModel() => Data = DateTime.UtcNow;
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }

        public string Subject { get; set; }
        [DataType(DataType.Time)]
        public DateTime Data { get; set; }

    }
}
