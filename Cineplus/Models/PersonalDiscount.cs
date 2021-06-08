using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Cineplus.Services;

namespace Cineplus.Models {
    public class PersonalDiscount: DbEntity {

        [Filter(FilterBy = "name")]
        [Sortable(OrderBy = "name")]
        public string Name { get; set; }
        
        [Column(TypeName="ntext")]
        public string Description { get; set; }

        public float Discount { get; set; }

        public bool Enable { get; set; } = true;
    }
}