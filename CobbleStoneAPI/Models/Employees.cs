using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CobbleStoneAPI.Models
{
    public partial class Employees
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        [Required]
        public int Age { get; set; }

        override
        public string ToString()
        {
            return "id: " + this.id + ", FirstName: " + this.FirstName + ", LastName: " + this.LastName + 
                ", Birthday: " + this.Birthday.Value.ToShortDateString() + ", Age: " + this.Age;
        }
    }
}
