using System;
using System.ComponentModel.DataAnnotations;

namespace AdoreSoap.Models
{
    public class Adore
    {

         public int Id { get; set; }
        [Required]//the name cannot be left bank
        public string Name { get; set; } //name of the soap this attribute has the get and set properties

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]   //the initial name was ReleaseDate but this is not readable that was why the display function is used to correct this
        public DateTime ReleaseDate { get; set; } //product release date
        public string Color { get; set; }

        [Required]//the purpose space cannot be left blank
        public string Purpose { get; set; }  //purpose of the soap which also has the  get and set properties
        public string Type { get; set; }     //type attribute which describes if it is bar,wash or lotion

        [Range(1, 100)]             //Range of numbers for this particular property
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }



        [Range(1, 5)] //the rating has to be within 1 and 5 if it is more than 5 it will throw an error
        [Required]//user has to enter the input if not the changes would not be accepted
        public int Rating { get; set; }

    }
}
