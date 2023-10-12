using System;
using System.ComponentModel.DataAnnotations;

namespace AdoreSoap.Models
{
    public class Adore
    {

         public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Color { get; set; }

        public string Purpose { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }


    }
}
