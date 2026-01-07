using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command) 
        {
            var values = _context.VarisNoktalaris.Find(command.id);
            _context.VarisNoktalaris.Remove(values);
            _context.SaveChanges();
        }
    }
}
