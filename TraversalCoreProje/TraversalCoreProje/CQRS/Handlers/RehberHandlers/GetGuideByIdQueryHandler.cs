using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProje.CQRS.Queries.RehberQueries;
using TraversalCoreProje.CQRS.Results.RehberResults;

namespace TraversalCoreProje.CQRS.Handlers.RehberHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Rehberlers.FindAsync(request.ID);
            return new GetGuideByIdQueryResult
            {
                RehberID = values.RehberID,
                Aciklama = values.Aciklama,
                Ad = values.Ad
            };
        }
    }
}
