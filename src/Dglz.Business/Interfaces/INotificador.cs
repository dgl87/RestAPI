using Dglz.Business.Notifications;

namespace Dglz.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        IEnumerable<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
