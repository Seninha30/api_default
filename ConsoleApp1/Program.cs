using Default.Domain.Interfaces;
using Default.Domain.Service;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserService();
            UserRequest user = new UserRequest();

            user.PassWord = "13";
            user.PrimeiroNome = "Ricardo";
            user.UltimoNome = "Sena";
            user.Email = "ricardoaraujosena@gmail.com";
            

            service.AddUser(user);

            Console.ReadKey();
        }
    }
}
