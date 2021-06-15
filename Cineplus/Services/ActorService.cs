using System.Collections.Generic;
using System.Linq;
using Cineplus.Models;
using Microsoft.EntityFrameworkCore;


namespace Cineplus.Services
{
    public class ActorService: IActorService
    {
        private IRepository<Actor> _actorRepository;
        private IRepository<ActorMovie> _actorMovieRepository;

        public ActorService(IRepository<Actor> actorRepository, IRepository<ActorMovie> actorMovieRepository)
        {
            _actorRepository = actorRepository;
            _actorMovieRepository = actorMovieRepository;
        }

        public Pagination<Actor> GetAll(Pagination<Actor> parameters)
        {
            return PaginationService.GetPagination(_actorRepository.Data(), parameters);
        }

        public Actor GetActor(int id)
        {
            return _actorRepository.Data()
                .Include(actor => actor.Movies)
                .FirstOrDefault(actor => actor.Id == id);
        }

        public Actor Add(Actor actor)
        {
            return _actorRepository.Add(actor);
        }

        public Actor Update(Actor actor)
        {
            return _actorRepository.Update(actor);
        }

        public ActorMovie[] AddCast(Actor[] cast, int movieId)
        {
            ActorMovie[] result = new ActorMovie[cast.Length];
            
            for (int i = 0; i < cast.Length; i++)
                result[i] = _actorMovieRepository.Add(new ActorMovie() {ActorId = cast[i].Id, MovieId = movieId});
            
            return result;
        }

        public Pagination<Actor> GetActorsInMovie(int movieId, Pagination<Actor> parameters)
        {
            return PaginationService.GetPagination(_actorRepository.Data()
                .Include(actor => actor.Movies)
                .Where(actor => actor.Movies.Any(actorMovie => actorMovie.MovieId == movieId)), parameters);
        }

        public ActorMovie[] UpdateCast(Actor[] cast, int movieId)
        {
            var currentCast = new List<ActorMovie>(_actorMovieRepository.Data()
                .Where(actorMovie => actorMovie.MovieId == movieId));

            for (int i = 0; i < currentCast.Count(); i++)
                _actorMovieRepository.Remove(currentCast[i].Id);

            ActorMovie[] result = new ActorMovie[cast.Length];
            
            for (int i = 0; i < cast.Length; i++)
                result[i] = _actorMovieRepository.Add(new ActorMovie() {ActorId = cast[i].Id, MovieId = movieId});
            
            return result;
        }
    }
}