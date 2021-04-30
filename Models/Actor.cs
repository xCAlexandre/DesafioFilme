using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Bcc.Models
{
    public class Actor
    {
        public int Id{get;set;}
        public string Name{get; set;}
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}