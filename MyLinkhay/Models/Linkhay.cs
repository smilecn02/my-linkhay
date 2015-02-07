using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyLinkhay.Models
{
    public class Linkhay
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        [Display(Name="Update Date")]
        public DateTime UpdateDate { get; set; }
    }
}