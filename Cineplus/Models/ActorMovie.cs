namespace Cineplus.Models
{
    public class ActorMovie: DbEntity
    {
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }
        
        public virtual int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}