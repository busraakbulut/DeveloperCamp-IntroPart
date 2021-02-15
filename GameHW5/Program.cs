using System;

namespace GameHW5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Büşra", LastName ="AKBULUT", IdentityNumber = 12345});
            gamerManager.Add(new Gamer { Id = 2, BirthYear = 2002, FirstName = "Ayşe", LastName = "AKBULUT", IdentityNumber = 12345 });
        }
    }
}
