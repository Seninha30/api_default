using Default.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Default.Domain.ObjectValues
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this)
                  .IfNotEmail(x => x.Endereco, Msg.X0_INVALIDO.ToFormat("e-mail"));
        }

        public string Endereco { get; set; }
    }
}
