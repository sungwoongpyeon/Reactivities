using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        // IRequest<List<Activity>>
        // <List<Activity>> This is a return type
        // This is the request that we want to receive
        public class Query : IRequest<List<Activity>> { }

        // IRequestHandler<Query, List<Activity>>
        // <Query, List<Activity>> This is a return type
        // This is how we handle the request
        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.ToListAsync();
            }
        }
    }
}