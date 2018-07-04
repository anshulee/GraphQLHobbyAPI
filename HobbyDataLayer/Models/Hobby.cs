using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDataLayer.Models
{
    public class Hobby
    {
        public Hobby()
        {
            this.People = new HashSet<Person>();
        }
        [Key]
        public int HobbyID { get; set; }
        [Required]
        public string Name { get; set; }
        public  ICollection<Person> People { get; set; }
    }
}
