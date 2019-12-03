using System;
using Default.Domain.Entity;

namespace Default.Domain.Arguments
{
    public class UserResponse
    {
        public int Id { get; set; }

        public static explicit operator UserResponse(User resp)
        {
            return new UserResponse()
            {
                Id = resp.Id;
          }
        }
    }
}
