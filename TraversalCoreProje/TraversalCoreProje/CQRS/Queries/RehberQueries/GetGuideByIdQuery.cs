using MediatR;
using TraversalCoreProje.CQRS.Results.RehberResults;

namespace TraversalCoreProje.CQRS.Queries.RehberQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
    }
}
