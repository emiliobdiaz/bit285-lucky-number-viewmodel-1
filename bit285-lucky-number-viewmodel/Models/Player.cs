using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public decimal Balance { get; set; }
    }
}