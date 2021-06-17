using Cineplus.Models;

namespace Cineplus.Services
{
    public interface IActorService
    {
        Pagination<Actor> GetAll(Pagination<Actor> parameters);
        Actor GetActor(int id);
        Actor Add(Actor actor);
        Actor Update(Actor actor);
        ActorMovie[] AddCast(Actor[] actor, int movieId);
        Pagination<Actor> GetActorsInMovie(int movieId, Pagination<Actor> parameters);
        ActorMovie[] UpdateCast(Actor[] cast, int movieId);
    }
}