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
    }
}