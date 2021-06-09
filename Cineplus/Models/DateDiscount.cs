using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Cineplus.Services;

namespace Cineplus.Models {
    public class DateDiscount: DbEntity {

        [Column(TypeName="ntext")] 
        public string Description { get; set; }
        
        public DateTime Date { get; set; }
        
        [Sortable(OrderBy = "discount")]
        public double Discount { get; set; }

        public bool Enable { get; set; } = true;
    }
}