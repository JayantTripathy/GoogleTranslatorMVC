using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoogleTranslateMVC.Models
{
    [Table("Translate")]
    public class Translate
    {
        [Key]
        public int Id { get; set; }
        public string HindiLanguage { get; set; }

        public string OriyLanguage { get; set; }
    }
}