using Default.Domain.Enuns;
using prmToolkit.NotificationPattern;
using System;

namespace Default.Domain.Entity.Base
{
    public abstract class BaseEntity : Notifiable
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public EnumAtivo Ativo { get; set; }
    }
}
