using System.Collections.Generic;
using System.Threading;
using AspNetCoreMediatRSample.Queries;
using MediatR;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Models;
using AspNetCoreMediatRSample.Data;
using System.Linq;

namespace AspNetCoreMediatRSample.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonList, IEnumerable<Person>>
    {
        private readonly DataContext context;

        public GetPersonListHandler(DataContext context)
        {
            this.context = context;
        }
        public Task<IEnumerable<Person>> Handle(GetPersonList request, CancellationToken cancellationToken)
        {
        var ctr = this.context.Persons.AsQueryable();
        return Task.FromResult(ctr.AsEnumerable<Person>());
        }
    }
}