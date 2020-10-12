using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Data;
using AspNetCoreMediatRSample.Models;
using AspNetCoreMediatRSample.Queries;
using MediatR;

namespace AspNetCoreMediatRSample.Handlers
{
    public class GetPersonHandler : IRequestHandler<GetPersonQuery, Person>
    {
        private readonly DataContext context;

        public GetPersonHandler(DataContext context)
        {
            this.context = context;
        }
        
        public Task<Person> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
           var ctx = this.context.Persons.Where(x => x.Id == request.Id).FirstOrDefault();
           return Task.FromResult(ctx);
        }
    }
}