using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IActorService
    {
        Pagination<Actor> GetAll(Pagination<Actor> parameters);
        Actor Add(Actor actor);
        Actor Update(Actor actor);
        ActorMovie AddParticipation(Actor actor, Movie movie);
    }
}