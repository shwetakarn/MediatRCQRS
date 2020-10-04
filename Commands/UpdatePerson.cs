using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Commands
{
    public class UpdatePerson : IRequest<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        

    }
}