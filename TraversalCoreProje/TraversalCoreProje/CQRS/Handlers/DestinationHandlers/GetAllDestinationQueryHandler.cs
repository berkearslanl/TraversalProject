using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.VarisNoktalariResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.VarisNoktalaris.Select(x => new GetAllDestinationQueryResult
            {
                id = x.VarisNoktasiID,
                Fiyat = x.Fiyat,
                GeceGunduz = x.GeceGunduz,
                Kapasite = x.Kapasite,
                Sehir = x.Sehir
            }).AsNoTracking().ToList();
            return values;
        }   
    }
}
