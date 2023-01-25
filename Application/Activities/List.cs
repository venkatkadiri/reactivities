using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Domain;
using Persistance;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { }

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            public readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return _context.Activities.ToListAsync();
            }
        }
    }
}