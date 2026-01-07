using MediatR;
using TraversalCoreProje.CQRS.Results.RehberResults;

namespace TraversalCoreProje.CQRS.Queries.RehberQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
