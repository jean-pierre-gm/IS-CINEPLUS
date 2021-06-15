using Cineplus.Models;
using Cineplus.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Controllers
{
    [Route("/api/[controller]")]
    public class ActorController : Controller
    {
        private IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }
        
        [HttpGet]
        public ActionResult<Pagination<Actor>> GetAll(Pagination<Actor> parameters)
        {
            return new ActionResult<Pagination<Actor>>(_actorService.GetAll(parameters));
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Actor> GetActor(int id)
        {
            return new ActionResult<Actor>(_actorService.GetActor(id));
        }

        [HttpGet]
        [Route("movie/{movieId:int}")]
        public ActionResult<Pagination<Actor>> GetActorsInMovie(int movieId, Pagination<Actor> parameters)
        {
            return new ActionResult<Pagination<Actor>>(_actorService.GetActorsInMovie(movieId, parameters));
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPut("{id:int}")]
        public ActionResult<Actor> PutActor(int id, [FromBody] Actor actor) {
            if (id != actor.Id) {
                return BadRequest();
            }
            return _actorService.Update(actor);
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPost]
        public ActionResult<Actor> PostActor([FromBody]Actor actor) {
            _actorService.Add(actor);
            return new ActionResult<Actor>(actor);
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPost]
        [Route("cast/{movieId:int}")]
        public ActionResult<ActorMovie[]> PostActorMovie(int movieId, [FromBody]Actor[] actors) {
            return new ActionResult<ActorMovie[]>(_actorService.AddCast(actors, movieId));
        }
        
        [Authorize(Roles = "Admin,Manager", AuthenticationSchemes = IdentityExtensions.AuthenticationScheme)]
        [HttpPut]
        [Route("cast/{movieId:int}")]
        public ActionResult<ActorMovie[]> PutMovieCast(int movieId, [FromBody]Actor[] actors) {
            return new ActionResult<ActorMovie[]>(_actorService.UpdateCast(actors, movieId));
        }
    }
}