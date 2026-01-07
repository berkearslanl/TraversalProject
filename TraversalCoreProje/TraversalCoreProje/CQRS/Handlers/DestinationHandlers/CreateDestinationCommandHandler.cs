using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        
        public void Handle(CreateDestinationCommand command)
        {
            _context.VarisNoktalaris.Add(new EntityLayer.Concrete.VarisNoktalari
            {
                Sehir = command.Sehir,
                GeceGunduz = command.GeceGunduz,
                Fiyat = command.Fiyat,
                Kapasite = command.Kapasite,
                Durum = true
            });
            _context.SaveChanges();
        }
    }
}
