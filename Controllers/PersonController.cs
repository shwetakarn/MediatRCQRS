using System.Threading.Tasks;
using AspNetCoreMediatRSample.Commands;
using AspNetCoreMediatRSample.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMediatRSample.Controllers
{
    [Route("api/Person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("create")]
    public async Task<ActionResult<Person>> Create(CreatePerson request)
    {
        var person = await mediator.Send(request);

        return person;
    }

        [HttpPost("update")]
        public async Task<ActionResult<Person>> Update(UpdatePerson request)
        {
        var person = await mediator.Send(request);

        return person;
        }

    [HttpPost("delete")]
    public async Task<IActionResult> Delete(DeletePerson request)
    {
        await mediator.Send(request);
        return Ok();
    }
    }
}