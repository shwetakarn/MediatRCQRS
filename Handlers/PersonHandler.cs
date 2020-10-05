using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspNetCoreMediatRSample.Commands;
using AspNetCoreMediatRSample.Data;
using AspNetCoreMediatRSample.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetCoreMediatRSample.Handlers
{
    public class PersonHandler : IRequestHandler<CreatePerson, Person>, IRequestHandler<UpdatePerson, Person>, IRequestHandler<DeletePerson>
    {

        private readonly DataContext ctx;

        public PersonHandler(DataContext context)
        {
            this.ctx = context;
        }

        //Implements and encapsulates real business logic

        //create
        public async Task<Person> Handle(CreatePerson request, CancellationToken cancellationToken)
        {
           var person = new Person()
           {
               FirstName = request.FirstName,
               Age = request.Age
           };
           ctx.Add(person);
           await ctx.SaveChangesAsync();
           return person;
        }

        //Update
        public async Task<Person> Handle(UpdatePerson request, CancellationToken cancellationToken)
        {
            var person = await ctx.Persons.SingleOrDefaultAsync(V => V.Id == request.Id);

            if(person == null)
            {
                throw new Exception("Record does not exist");
            }

            person.FirstName = request.FirstName;
            person.Age = request.Age;
            
            ctx.Persons.Update(person);
            await ctx.SaveChangesAsync();
            return person;
        }

        //Deletes
        public async Task<Unit> Handle(DeletePerson request, CancellationToken cancellationToken)
        {
            var person = await ctx.Persons.SingleOrDefaultAsync(v => v.Id == request.Id);
            if(person == null)
            {
                throw new Exception("Record not found");
            }

            ctx.Persons.Remove(person);
            await ctx.SaveChangesAsync();
            return Unit.Value;
        }
    }
}