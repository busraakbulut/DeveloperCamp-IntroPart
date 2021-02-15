using System;
using System.Collections.Generic;
using System.Text;

namespace GameHW5
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName == "Büşra" && gamer.LastName == "AKBULUT" && gamer.IdentityNumber==12345 && gamer.Id ==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
