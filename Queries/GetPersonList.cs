using System.Collections.Generic;
using AspNetCoreMediatRSample.Models;
using MediatR;

namespace AspNetCoreMediatRSample.Queries
{
    public class GetPersonList:IRequest<IEnumerable<Person>>
    {
        
    }
}