using Cineplus.Models;

namespace Cineplus.Services
{
    public class ActorService: IActorService
    {
        private IRepository<Actor> _actorRepository;

        public ActorService(IRepository<Actor> actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public Pagination<Actor> GetAll(Pagination<Actor> parameters)
        {
            return PaginationService.GetPagination(_actorRepository.Data(), parameters);
        }

        public Actor Add(Actor actor)
        {
            return _actorRepository.Add(actor);
        }

        public Actor Update(Actor actor)
        {
            return _actorRepository.Update(actor);
        }

        public ActorMovie AddParticipation(Actor actor, Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}