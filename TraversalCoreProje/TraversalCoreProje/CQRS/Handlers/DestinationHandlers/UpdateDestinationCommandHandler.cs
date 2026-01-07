using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.VarisNoktalaris.Find(command.DestinationId);
            values.Sehir = command.Sehir;
            values.GeceGunduz = command.GeceGunduz;
            values.Fiyat = command.Fiyat;
            _context.SaveChanges();
        }
    }
}
