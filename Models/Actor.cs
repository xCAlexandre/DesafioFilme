using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Bcc.Models
{
    public class Actor
    {   

        public int Id {get; set;}
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string Name {get; set;}
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}