namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string Sehir { get; set; }
        public string GeceGunduz { get; set; }
        public double Fiyat { get; set; }
        public int Kapasite { get; set; }
        public bool Durum { get; set; }
    }
}
