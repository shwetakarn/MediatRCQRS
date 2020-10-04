using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Commands
{
    public class DeletePerson : IRequest
    {
        public int Id { get; set; }
    }
}