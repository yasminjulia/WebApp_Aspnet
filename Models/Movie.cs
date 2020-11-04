using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public String Description { get; set; }
        public String Cover {get;set;}
    }
}