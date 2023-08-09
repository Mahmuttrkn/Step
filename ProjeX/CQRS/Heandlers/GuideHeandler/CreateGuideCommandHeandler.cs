using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using ProjeX.CQRS.Commands.GuideCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProjeX.CQRS.Heandlers.GuideHeandler
{
    public class CreateGuideCommandHeandler : IRequestHandler<CreateGuideCommmand>
    {
        private readonly Context context;

        public CreateGuideCommandHeandler(Context context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommmand request, CancellationToken cancellationToken)
        {
            context.Guids.Add(new Guide
            {
                Name=request.Name,
                Description=request.Description,
                Status=true
            });
            await context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
