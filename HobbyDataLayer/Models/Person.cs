using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDataLayer.Models
{
    public class Person
    {
        public Person()
        {
            this.Hobbies = new HashSet<Hobby>();
        }
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public  ICollection<Hobby> Hobbies { get; set; }
    }
}
