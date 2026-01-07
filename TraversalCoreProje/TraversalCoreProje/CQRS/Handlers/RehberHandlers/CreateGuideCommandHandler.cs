using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProje.CQRS.Commands.GuideCommand;

namespace TraversalCoreProje.CQRS.Handlers.RehberHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommands>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommands request, CancellationToken cancellationToken)
        {
            _context.Rehberlers.Add(new EntityLayer.Concrete.Rehberler
            {
                Ad=request.Ad,
                Aciklama=request.Aciklama,
                Durum=true,
                Resim=request.Resim,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
