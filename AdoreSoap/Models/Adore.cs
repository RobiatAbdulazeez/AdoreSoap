using System;
using System.ComponentModel.DataAnnotations;

namespace AdoreSoap.Models
{
    public class Adore
    {

         public int Id { get; set; }
        [Required]//the name cannot be left bank
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Color { get; set; }

        [Required]//the purpose space cannot be left blank
        public string Purpose { get; set; }
        public string Type { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }



        [Range(1, 5)] //the rating has to be within 1 and 5 if it is more than 5 it will throw an error
        [Required]//user has to enter the input if not the changes would not be accepted
        public int Rating { get; set; }

    }
}
