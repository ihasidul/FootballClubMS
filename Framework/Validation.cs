using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballClubMS.Entity;
using FootballClubMS.Repository;
namespace FootballClubMS.Framework
{
    public static class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }

        public static bool IsUserInDB(LoginEntity l)//serach for the loginEntity object in login table
        {
            if (LoginRepository.SearchUser(l) == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
