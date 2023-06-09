﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Cineplus.Services;

namespace Cineplus.Models {
    public class PersonalDiscount: DbEntity {

        [Filter(FilterBy = "name")]
        [Sortable(OrderBy = "name")]
        public string PersonalName { get; set; }
        
        [Column(TypeName="ntext")]
        public string Description { get; set; }

        [Sortable(OrderBy = "discount")]
        public double Discount { get; set; }
        
        [JsonIgnore]
        public virtual List<Ticket> Tickets { get; set; }
        public bool Enable { get; set; } = true;
    }
}