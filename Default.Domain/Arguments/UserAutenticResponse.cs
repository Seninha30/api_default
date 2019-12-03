using System;
using Default.Domain.Entity;

namespace Default.Domain.Arguments
{
    public class UserAutenticResponse
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }

        public static explicit operator UserAutenticResponse(User resp)
        {
            return new UserAutenticResponse()
            {
                PrimeiroNome = resp.Nome.PrimeiroNome,
                Id = resp.Id
            };
        }
    }
}
