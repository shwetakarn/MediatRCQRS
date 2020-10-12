using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Queries
{
    public class GetPersonQuery:IRequest<Person>
    {
        public int Id {get;}

        public GetPersonQuery(int id)
        {
            Id = id;
        }
    }
}