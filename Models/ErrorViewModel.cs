using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey3.Models
{
    public class Dojo
    {
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name {get; set;}

        
        [MinLength(8)]
        [MaxLength(30)]
        public string Comment {get;set;}

        [Required]
        public string Location{get; set;}
        
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Language{get; set;}


    }
}