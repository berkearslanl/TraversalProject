namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string Sehir { get; set; }
        public string GeceGunduz { get; set; }
        public double Fiyat { get; set; }
    }
}
