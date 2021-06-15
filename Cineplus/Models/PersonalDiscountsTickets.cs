namespace Cineplus.Models
{
    public class PersonalDiscountsTickets
    {
        public string PersonalDiscountId { get; set; }
        
        public PersonalDiscount PersonalDiscount { get; set; }
        
        public string TicketId { get; set; }
        
        public Ticket Ticket { get; set; }
    }
}