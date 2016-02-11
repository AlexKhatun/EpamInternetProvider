﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Rate
    {
        public int RateId { get; set; }

        [Required]
        public Service Service { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PriceStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PriceFinishDate { get; set; }

        public virtual ICollection<Subscribe> Subscribes { get; set; } 
    }
}