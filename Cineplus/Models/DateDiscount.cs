using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cineplus.Models {
    public class DateDiscount: DbEntity {
        [Column(TypeName="ntext")] 
        public string Description { get; set; }

        public DateTime Date { get; set; }
        
        public float Discount { get; set; }
    }
}