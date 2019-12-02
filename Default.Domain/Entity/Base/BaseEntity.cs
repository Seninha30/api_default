using Default.Domain.Enuns;
using prmToolkit.NotificationPattern;
using System;

namespace Default.Domain.Entity.Base
{
    public abstract class BaseEntity : Notifiable
    {
        public int Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public EnumAtivo Ativo { get; private set; }

        public void SetAtivo(EnumAtivo enumAtivo)
        {
            Ativo = enumAtivo;
        }
    }
}
