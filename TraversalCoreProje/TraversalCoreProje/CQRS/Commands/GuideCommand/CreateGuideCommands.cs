using MediatR;

namespace TraversalCoreProje.CQRS.Commands.GuideCommand
{
    public class CreateGuideCommands:IRequest
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
