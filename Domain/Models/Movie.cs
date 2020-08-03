using System;
using DotNetExperience.InterfaceAdapters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetExperience.Domain.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
