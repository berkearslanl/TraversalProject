using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.VarisNoktalariResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery p)
        {
            var values = _context.VarisNoktalaris.Find(p.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.VarisNoktasiID,
                GeceGunduz = values.GeceGunduz,
                Sehir = values.Sehir,
                Fiyat = values.Fiyat
            };
        }
    }
}
