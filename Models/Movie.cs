using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Bcc.Models
{
    public class Movie
    {
        public int Id {get; set;}
        
        [StringLength(60, MinimumLength = 3), Required]
        public string Title {get; set;}
        
        [Display(Name = "Data de Lançamento"), DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string Genre {get; set;}
      
        [Range(1,100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Price {get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5), Required]
        public string Rating {get; set;}


        public List<Actor> Actors{get;set;}

        // public List<Actor> GetActors(){
        //     List<Actor> actors = new List<Actor>();
        //     return actors;
        // }

    }
}