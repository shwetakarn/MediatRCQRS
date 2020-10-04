using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Commands
{
    public class CreatePerson : IRequest<Person>
    {
        public string FirstName { get; set; }
        public int Age { get; set; }

    }
}