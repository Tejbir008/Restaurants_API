using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants_API.Model
{
    public class Restaurant
    {
        [Key]
        public int Restaurant_ID { get; set; }
        [Required]
        public string Restaurant_Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email_Id { get; set; }
        [Required]
        public string Contact_Number { get; set; }
    }
}
