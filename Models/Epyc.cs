using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Epyc
    {
        [Key]
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        
        public ICollection<Task> Tasks { get; set; }
    }
}
