using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cineplus.Models
{
    public class Ticket : DbEntity
    {
        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public double Price { get; set; }

        public DateDiscount DateDiscount { get; set; }

        public virtual List<PersonalDiscount> PersonalDiscounts { get; set; }

        public double PointsPrice { get; set; }

        public Guid OrderId { get; set; }
        [JsonIgnore] public Guid Confirmation { get; set; }
        public DateTime ReserveTime { get; set; }
        public int ReproductionId { get; set; }

        public virtual Reproduction Reproduction { get; set; }
    }
}